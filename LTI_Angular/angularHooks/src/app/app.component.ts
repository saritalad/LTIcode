import { Component,OnChanges, SimpleChange } from '@angular/core';

@Component({
  selector: 'app-root',
  template: '             ',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angularHooks';
isListvisible:boolean=true;
child:any="sending data to child";
HideList()
{

  this.isListvisible=false;
}

myfunction(val:any)
{
this.child=val;
console.log(this.child);
}

}
