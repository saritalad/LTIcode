import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Binding_In_Angular';
  public name="ABC Computers";

  public value="";
  public image="../assets/images/bai2.jpg"
  public clickcount:number=0;
  public val:string='';
  public value3:string='';


  clickMe()
  {
    this.clickcount++;
  }
  


  
}
