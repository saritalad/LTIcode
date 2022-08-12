import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { User } from '../MODEL/user';
import { UserService } from '../user.service';

@Component({
  selector: 'userlist',
  templateUrl: './userlist.component.html',
  styleUrls: ['./userlist.component.css']
})
export class UserlistComponent implements OnInit {
users:User[]=[];
  constructor(private service :UserService) { }
usersubscription:Subscription;
  ngOnInit(): void {

   this.usersubscription=this.service.getusers().subscribe(response=>{this.users=response});

 }
 ngOnDestroy()
 {
   console.log('ngondestroy initialized');
    this.usersubscription.unsubscribe();

 }

}
