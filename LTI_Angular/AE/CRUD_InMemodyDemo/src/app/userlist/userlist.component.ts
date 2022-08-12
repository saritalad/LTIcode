import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { User, UserserviceService } from '../userservice.service';
@Component({
  selector: 'app-userlist',
  templateUrl: './userlist.component.html',
  styleUrls: ['./userlist.component.css']
})
export class UserlistComponent implements OnInit {
  public usersfromservice: User[] = [];
  constructor(private _userservice: UserserviceService, private router: Router, private route: ActivatedRoute) {
  }
  MoreInfo(user: User) {
    this.router.navigate(['/userlist', user.id]);
    alert('username :' + user.firstname + ' ' + user.lastname);

  }


  ngOnInit(): void {
    this.getAllUsersFromService();
  }

  getAllUsersFromService() {

    this.usersfromservice = this._userservice.getUsers()

  }

  deleteuser(id: number) {
    if (confirm("are u sure ? ")) {
      this._userservice.RemoveUser(id);
      alert('user deleted');
      this.getAllUsersFromService();
    }
    
  }
}
