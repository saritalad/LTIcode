import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  msg:string='';
  @Input() userName:string;
  constructor()
  {
  
    }
  ngOnInit()
  {
    this.msg=`Hello ${this.userName}`;
  }
}
