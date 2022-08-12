import { Component, Input, OnInit } from '@angular/core';
import{Output,EventEmitter}from '@angular/core';
@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {
@Input()myInputMsg:string ='';
@Input() getPrice:Number | undefined;
@Input() mystudents :Array<string> | undefined;
@Output() newItemEvent = new EventEmitter<string>();
  constructor() {console.log(this.myInputMsg); }
  ngOnInit(): void
  {
    console.log(this.myInputMsg);
  }

  addNewItem(value: string) {
    this.newItemEvent.emit(value);
  }

}
