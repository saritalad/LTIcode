import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dateformat',
  templateUrl: './dateformat.component.html',
  styleUrls: ['./dateformat.component.css']
})
export class DateformatComponent implements OnInit {
  dateVal=Date.now();
  constructor() { }

  ngOnInit(): void {
  }

}
