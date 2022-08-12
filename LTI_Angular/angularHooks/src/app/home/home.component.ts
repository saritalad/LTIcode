import { Component, Input,OnChanges, OnInit, SimpleChange, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnChanges {
@Input()MyInput:any;
  constructor() { }
  ngOnChages(changes:SimpleChange)
  {
    console.log(changes + "i am in ngOnChanges");
  }
ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
}
  ngOnInit(): void {
    console.log("I am in ngOnInit");
  }
 
}
