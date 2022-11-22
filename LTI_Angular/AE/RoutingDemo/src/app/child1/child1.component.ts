import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { elementAt } from 'rxjs';

@Component({
  selector: 'app-child1',
  templateUrl: './child1.component.html',
  styleUrls: ['./child1.component.css']
})
export class Child1Component implements OnInit {

  constructor(private route:Router,private active:ActivatedRoute) { }
id:any=2;
  ngOnInit(): void {
  }
  onSubmit()
  {  
  let Id= prompt("enter value of Id","0");
this.id=Id
    if(this.id==1)
    this.route.navigate(['grandchild1'],{relativeTo:this.active})
    else
    if(this.id=2)
    this.route.navigate(['grandchild2'],{relativeTo:this.active})

  } 



}
