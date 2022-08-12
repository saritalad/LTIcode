import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-attrbt',
  templateUrl: './my-attrbt.component.html',
  styleUrls: ['./my-attrbt.component.css']
})
export class MyAttrbtComponent implements OnInit {
val:number=12;
result:string='';
  constructor() { }
  getClassOf(val:number) {
    if (val >= 0 && val <= 5) {
     this.result='low';
     return this.result;
    } else if (val > 5 && val <= 10) {
      return this.result='medium';
    } else {
      return this.result='high'
    }
  }
  ngOnInit(): void {
  }

}
