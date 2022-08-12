import { Component, Input, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {
  ngOnInit(): void {
   // throw new Error('Method not implemented.');
   console.log("I am coming from ngOnInit")
  }
  @Input() count: number=0;
  constructor() { }

  ngOnChanges(changes: SimpleChanges) {

      for (let property in changes) {
          if (property === 'count') {
            console.log('Previous:', changes[property].previousValue);
            console.log('Current:', changes[property].currentValue);
            console.log('firstChange:', changes[property].firstChange);
          } 
      }
 
 

}
}
