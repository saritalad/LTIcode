import { Component, OnInit } from '@angular/core';
import { User } from '../userservice.service';

@Component({
  selector: 'app-user-over-view',
  templateUrl: './user-over-view.component.html',
  styleUrls: ['./user-over-view.component.css']
})
export class UserOverViewComponent implements OnInit {
user :User;
id:number;

  constructor() { }

  ngOnInit(): void {
  }

}
