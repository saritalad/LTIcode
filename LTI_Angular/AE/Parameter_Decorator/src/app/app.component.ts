import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Parameter_Decorator';
 myInput:string ="I am coming from parent component"  ;
price :Number=12.50;
students :Array<string>=["Bill","Nill","Mill"]
items = ['item1', 'item2', 'item3', 'item4'];
fontSizePx = 16;
addItem(newItem: string) {
  this.items.push(newItem);
}


}
