import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IUser } from '../user';
import { UserService } from '../user.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {
  public currentuser: IUser;
  constructor(private _userservice: UserService, private router: Router, private activedoute: ActivatedRoute) { }
id:any;
  ngOnInit(): void {
    this.id = this.activedoute.snapshot.params["id"];
       this._userservice.getuserById(Number(this.id))
      .subscribe(user => {this.currentuser = user;});
     
      console.log(this.currentuser);
  }

  onSubmit(login:any)
  {
    this._userservice.update(login);
    this.router.navigate(['/userlist']);


  }
// ngOnInit(): void {

    //   this.id = this.activatedRoute.snapshot.params['id'];
  
    //   this.employee = this.empService.getEmployeeById(Number(this.id));
  
    // }


}
