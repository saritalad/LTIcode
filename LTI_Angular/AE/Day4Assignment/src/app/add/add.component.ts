import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from '../user.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {
  usersfromservice: any[] = [];
  constructor(private _userservice: UserService, private router: Router, private activeroute: ActivatedRoute) { }

  ngOnInit(): void {
  }

  onSubmit(login: any) {
    this._userservice.AddUser(login).subscribe((response)=>{
      this._userservice.getUsers();
    },(error=>{

    }));
    this.router.navigate(['/userlist']);

  }








}
