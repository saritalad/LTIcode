import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User, UserserviceService } from '../userservice.service';
@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent  {
  public usersfromservice:User[]=[];
  constructor(private _userservice:UserserviceService,private router:Router) { }
             ////////_service :empService
 
  onSubmit(login:any)
  {
     this._userservice.AddUser(login)
    alert("User Added Successfully");
     this.router.navigate(['/userlist']);
  }

}
