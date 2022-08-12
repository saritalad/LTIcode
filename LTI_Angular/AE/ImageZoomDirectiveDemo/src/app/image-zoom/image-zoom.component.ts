import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-image-zoom',
  templateUrl: './image-zoom.component.html',
  styleUrls: ['./image-zoom.component.css']
})
export class ImageZoomComponent implements OnInit {
  @Input('src') src: string='./assets/p5.jpg';
  @Input('xPos') xPos: number;
  @Input('yPos') yPos: number;
image:string='/assets/p5.jpg'
  constructor() {
    this.xPos = 50;
    this.yPos = 50;
  }

  ngOnInit(): void {
  }

}
