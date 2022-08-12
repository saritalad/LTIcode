import { Component } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
user :User={
  id:1,firstname:'leena',imageUrl:'/assets/p2.jpg'
};

  title = 'Day2Assignmnt';
}
export class User {
  id:number=1;
  firstname:string='';
     imageUrl:string='';
   
}