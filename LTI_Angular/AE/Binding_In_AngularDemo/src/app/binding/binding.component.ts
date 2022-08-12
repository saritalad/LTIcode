import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-binding',
  templateUrl: './binding.component.html',
  styleUrls: ['./binding.component.css']
})
export class BindingComponent implements OnInit {
public value:Number=10;
public value1:number=20.50;
public array :Array<number>=[12,24,36,67];
public dt1:Date=new Date();
public status:boolean=true;

public returnString(): string {  
      return "String return from function";  
  }  
  constructor() { }

  ngOnInit(): void {
  }

}
