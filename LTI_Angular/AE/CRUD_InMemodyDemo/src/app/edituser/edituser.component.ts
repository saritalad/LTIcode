import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validator, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { UserserviceService } from '../userservice.service';
@Component({
  selector: 'app-edituser',
  templateUrl: './edituser.component.html',
  styleUrls: ['./edituser.component.css']
})
export class EdituserComponent implements OnInit {
  emailPattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  userForm = new FormGroup({
    id:new FormControl('', [Validators.required, Validators.minLength(1)]),
    firstname: new FormControl('', [Validators.required, Validators.minLength(4)]),
    lastname: new FormControl('', [Validators.required, Validators.minLength(4)]),
    email: new FormControl('', [Validators.email]),
    profession: new FormControl('', [Validators.required, Validators.minLength(4)]),

  })
  constructor(private _userservice: UserserviceService, private router: Router, private activedoute: ActivatedRoute) {
 
  }

  ngOnInit(): void {
    let id = this.activedoute.snapshot.params["id"];
 
    let user = this._userservice.getUserById(id);

    



    this.userForm = new FormGroup({
       id:new FormControl(user?.id),
      firstname: new FormControl(user?.firstname, [Validators.required, Validators.minLength(4)]),
      lastname: new FormControl(user?.lastname,[Validators.required,Validators.minLength(4)]),
      email: new FormControl(user?.email,[Validators.email]),
      profession: new FormControl(user?.profession,[Validators.required,Validators.pattern(this.emailPattern)]),

    })

  }

  get Firstname() {
    // return this.userForm.get('firstname');
    return this.userForm.controls['firstname'];
  }

  get Lastname() {
    // return this.userForm.get('firstname');
    return this.userForm.controls['lasstname'];
  }
  get Email() {
    // return this.userForm.get('firstname');
    return this.userForm.controls['email'];
  }

  get Profession() {
    // return this.userForm.get('firstname');
    return this.userForm.controls['profession'];
  }




  onSubmit() {
   this._userservice.updateUser(this.userForm.value);
   this.router.navigate(['/userlist']);
  }

}
