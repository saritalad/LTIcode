import { Component } from '@angular/core';
import { EmpService } from './emp.service';
import { IEmployee } from './IEmployee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MyEmployeeExample';
  constructor(private empservice:EmpService){}



}
