import { Component, OnInit } from '@angular/core';
import { EmpService } from '../emp.service';
import { IEmployee } from '../IEmployee';

@Component({
  selector: 'app-emp-list',
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css']
})
export class EmpListComponent implements OnInit {

  constructor(private empservice:EmpService) { }
  employees:IEmployee[]=[];

  ngOnInit()
  {
  
  this.empservice.getEmployees()
  .subscribe(data=>{this.employees=data},
   ()=> console.log(this.employees)
   );
  
  
  }
  
  

}
