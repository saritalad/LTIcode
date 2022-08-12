import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from '../userservice.service';

@Component({
  selector: 'app-user-card',
  templateUrl: './user-card.component.html',
  styleUrls: ['./user-card.component.css']
})
export class UserCardComponent implements OnInit {
  @Input()
  public user: any;
  userid:number=0;
 
  constructor(private router :Router,private Actroute:ActivatedRoute) { }

  ngOnInit(): void {
    // let id=parseInt(this.Actroute.snapshot.params['id']);
    // this.userid=id;
  }
  ShowOverView()
  {
    this.router.navigate(['OverView'],{relativeTo:this.Actroute});
  }
  ShowContact()
  {
    this.router.navigate(['Contact'],{relativeTo:this.Actroute});
  }
}
