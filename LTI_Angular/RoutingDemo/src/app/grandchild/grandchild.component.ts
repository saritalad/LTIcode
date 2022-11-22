import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-grandchild',
  templateUrl: './grandchild.component.html',
  styleUrls: ['./grandchild.component.css']
})
export class GrandchildComponent implements OnInit {
currentuser:string=" ";
  constructor() { }

  ngOnInit(): void {
      this.currentuser=JSON.stringify(sessionStorage.getItem("name"))
      let I=sessionStorage.getItem("ID");
      console.log("Id:"+I+this.currentuser)
  }

}
