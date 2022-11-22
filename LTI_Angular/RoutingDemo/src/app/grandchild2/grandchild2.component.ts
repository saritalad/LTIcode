import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-grandchild2',
  templateUrl: './grandchild2.component.html',
  styleUrls: ['./grandchild2.component.css']
})
export class Grandchild2Component implements OnInit {
currentuser:string="";
  constructor() { }

  ngOnInit(): void {
    this.currentuser=JSON.stringify(sessionStorage.getItem("name"))
    alert(this.currentuser)
  }

}
