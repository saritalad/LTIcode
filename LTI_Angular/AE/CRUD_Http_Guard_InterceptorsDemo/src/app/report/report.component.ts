import { HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AppUser } from '../auth-module/AppUser';
import { AuthService } from '../auth-module/auth.service';
@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.css']

})
export class ReportComponent implements OnInit {
 public usersfromservice:any=[];
 public employeesfromservice=[];
 
  constructor(private _userservice:AuthService,private activeroute:ActivatedRoute) {
    this._userservice.list() .subscribe(users=>{this.usersfromservice=users; });
   }

  ngOnInit(): void {
    console.log(this.activeroute.snapshot.data);
    this._userservice.list() .subscribe(users=>{this.usersfromservice=users; });
    
    
   
  }

}
