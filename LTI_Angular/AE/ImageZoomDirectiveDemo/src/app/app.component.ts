import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ImageZoomDirective';
  @ViewChild('hello', { static: false }) ImgHello: ElementRef;
  name:string="Seema";
  srcImageZoom: string;
  showZoom: boolean;
  xPos: number;
  yPos: number;
  srcImg:string='/assets/p5.jpg';
  srcImage:string;
  width:number;
  constructor(private el:ElementRef)
  {el=this.ImgHello;
    this.showZoom = false;
    this.srcImage = this.srcImg;
    this.srcImageZoom = "image-zoom.jpg";
  }
  openZoom(event: any, show: boolean) {
    event.preventDefault();
    this.showZoom = show;
    if (show) {
      this.positionZoom(event);
    }
  }
  
  positionZoom(event:any) {
    let xPos = event.touches[0].pageX - event.touches[0].target.offsetLeft
    let yPos = event.touches[0].pageY - event.touches[0].target.offsetTop;
    let xMax = event.target.clientWidth;
    let yMax = event.target.clientHeight;
    this.xPos = this.validPercent(Math.round(xPos * 100 / xMax));
    this.yPos = this.validPercent(Math.round(yPos * 100 / yMax));
  }

  validPercent(value:number) {
    if (value < 0) {
      this.showZoom = false;
      return 0;
    };
    if (value > 100) {
      this.showZoom = false;
      return 100
    };
    return value;
  }


}
