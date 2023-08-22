import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-propertbinging',
  templateUrl: './propertbinging.component.html',
  styleUrls: ['./propertbinging.component.css']
})
export class PropertbingingComponent implements OnInit {
public name:string ="Sarita";
public profession:string="dot net trainer";
public user={name:"Sarita",email:"sarita_lad@rediffmail.com"}

public showAlert() : void { 
  console.log('You clicked on the button...');  
  alert("Click Event Fired...");  
}  
  constructor() { }

  ngOnInit(): void {
    
  }

}
