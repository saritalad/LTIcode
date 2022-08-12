import { Component, OnInit } from '@angular/core';
import { HighlightPipe } from '../highlight.pipe';
@Component({
  selector: 'app-userlist',
  templateUrl: './userlist.component.html',
  styleUrls: ['./userlist.component.css']
})
export class UserlistComponent implements OnInit {
  public users: User[]=[
    {id:1,firstname:'Bill',lastname:' gates',email:'billg@gmail.com',profession:'IT businessman',dateOfBirth
    :new Date(),imageUrl:'/assets/images/p1.jpg'},
    {id:2,firstname:'Sara',lastname:' Samwel',email:'SaraSamwel@gmail.com',profession:'Angular Trainer',dateOfBirth
    :new Date(7, 15, 2015),imageUrl:'/assets/images/p2.jpg'},
    {id:3,firstname:'Manoj',lastname:' Kumar',email:'ManojKumar@gmail.com',profession:'DotNet Trainer',dateOfBirth
    :new Date(8, 19, 2017),imageUrl:'/assets/images/p3.jpg'},
    {id:4,firstname:'Leena',lastname:' Chandawarkar',email:'LeenaChandawarkar@gmail.com',profession:'Actor',dateOfBirth
    :new Date(1, 11, 2009),imageUrl:'/assets/images/p4.jpg'},
    {id:5,firstname:'Smita',lastname:' Rajwade',email:'SmitaRajwade@gmail.com',profession:'Physiotherapist',dateOfBirth
    :new Date(12, 1, 1962),imageUrl:'/assets/images/p5.jpg'},
    {id:6,firstname:'Sona',lastname:' Sud',email:'SonaSud@gmail.com',profession:'Physiotherapist',dateOfBirth
    :new Date(12, 7, 1969),imageUrl:''}
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
export class User {
  id:number=1;
  firstname:string='';
  lastname:string='';
   email:string='';
   profession:string='';
    dateOfBirth:Date=new Date();
    imageUrl:string='';
   
}