import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IUser } from '../user';
import { UserService } from '../user.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  emailPattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  public currentuser: IUser
  userForm = new FormGroup({
    id: new FormControl('', [Validators.required, Validators.minLength(1)]),
    firstname: new FormControl('', [Validators.required, Validators.minLength(4)]),
    lastname: new FormControl('', [Validators.required, Validators.minLength(4)]),
    email: new FormControl('', [Validators.email]),
    profession: new FormControl('', [Validators.required, Validators.minLength(4)]),

  })
  constructor(private _userservice: UserService, private router: Router, private activedoute: ActivatedRoute) { }
  ngOnInit(): void {
    let id = this.activedoute.snapshot.params["id"];
    console.log(" id "+id);
    this._userservice.getuserById(id)
      .subscribe(
        user => {
          this.currentuser = user;
        }
      )

    this.userForm = new FormGroup({
      id: new FormControl(this.currentuser?.id),
      firstname: new FormControl(this.currentuser?.firstname, [Validators.required, Validators.minLength(4)]),
      lastname: new FormControl(this.currentuser?.lastname, [Validators.required, Validators.minLength(4)]),

      profession: new FormControl(this.currentuser?.age, [Validators.required, Validators.pattern(this.emailPattern)]),

    })
  }
  onSubmit() {
    this._userservice.update(this.userForm.value)
    this.router.navigate(['/userlist']);
   }

  get Firstname() {
    // return this.userForm.get('firstname');
    return this.userForm.controls['firstname'];
  }

  get Lastname() {
    // return this.userForm.get('firstname');
    return this.userForm.controls['lasstname'];
  }

  get Age() {
    // return this.userForm.get('firstname');
    return this.userForm.controls['age'];
  }

 


}
