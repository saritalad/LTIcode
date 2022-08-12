import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmpService } from '../emp.service';
import { IEmployee } from '../IEmployee';

@Component({
  selector: 'app-add-emp',
  templateUrl: './add-emp.component.html',
  styleUrls: ['./add-emp.component.css']
})
export class AddEmpComponent implements OnInit {
  emp: IEmployee = {
    id: 0,
    employeeId: '',
    name: '',
    age: 0,
    designation: '',
    salary: 0,
    joinDate: '',
    maritalStatus: '',
    projectAssigned: '',
    imageUrl: '',
  };
  mstatus: string[] = ["married", "unmarried"];
  constructor(private _empsvc: EmpService, private router: Router) { }

  onSubmit(addempfrm: any) {
    this._empsvc.AddEmployee(addempfrm)
    .subscribe(
      response => {
        console.log(response);
        this.router.navigate(['/emplist']);
      },
      error => {
        console.log(error);
      },
    );



  }
  ngOnInit(): void {
  }

}
