import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-json',
  templateUrl: './json.component.html',
  styleUrls: ['./json.component.css']
})
export class JsonComponent implements OnInit {

  constructor() { }
  jsonVal: Object = {moo: 'foo', goo: {too: 'new'}};
  ngOnInit(): void {
  }

}
