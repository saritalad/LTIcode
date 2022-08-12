import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmpService } from '../emp.service';
import { IEmployee } from '../IEmployee';

@Component({
  selector: 'app-emp-details',
  templateUrl: './emp-details.component.html',
  styleUrls: ['./emp-details.component.css']
})
export class EmpDetailsComponent implements OnInit {

  constructor(private empservice:EmpService,private router:Router,private activerout:ActivatedRoute) {    }
  employee:IEmployee;
  ngOnInit(): void {
    let id = this.activerout.snapshot.params['id'];
    this.empservice.GetEmpById(id)
    .subscribe(data=>{this.employee=data},
     ()=> console.log(this.employee),
  
     );

  }

}
