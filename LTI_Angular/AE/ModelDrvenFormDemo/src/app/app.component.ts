import { Component } from '@angular/core';
import { FormGroup,FormControl,Validator, Validators } from '@angular/forms';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'model driven form:';
  countryList :Country[]=[{id:"1",name:"India"},{id:"2",name:"USA"},{id:"3",name:"England"}];
  onSubmit() {
    console.log(this.contactForm.value);
  }
  contactForm = new FormGroup({
    firstname: new FormControl('', [Validators.required, Validators.minLength(10)]),
    lastname: new FormControl(),
    email: new FormControl(),
    gender: new FormControl(),
    isMarried: new FormControl(),
    country: new FormControl()
  })
  get firstname() {
    return this.contactForm.get('firstname');
 } 
}
export class Country{
  id :string="";
  name:string="";
}