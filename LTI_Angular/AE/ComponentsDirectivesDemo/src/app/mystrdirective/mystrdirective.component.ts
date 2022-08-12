import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mystrdirective',
  templateUrl: './mystrdirective.component.html',
  styleUrls: ['./mystrdirective.component.css']
})
export class MystrdirectiveComponent  {

  constructor() { }
  friends :string[]= ["Akash", "Nilesh", "Seema", "Sudha","Deepak"];
 number=prompt("enter a number ","one");

}
