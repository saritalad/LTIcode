import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-userlist',
  templateUrl: './userlist.component.html',
  styleUrls: ['./userlist.component.css']
})
export class UserlistComponent implements OnInit {
  usersfromservice: any = [];
  constructor(private _userservice:UserService) { }

  ngOnInit(): void {
    this._userservice.getUsers()
      .subscribe(data => this.usersfromservice = data);
  }






  

  deleteuser(id:number)
  {if(confirm("are u sure ?"))

this._userservice.delete(id);

  }
}



