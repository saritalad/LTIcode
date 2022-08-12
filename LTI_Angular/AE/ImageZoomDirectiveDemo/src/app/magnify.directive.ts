import { Directive, ElementRef, HostBinding, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[Magnify]'
})
export class MagnifyDirective {
  private elementSelected = false;
   constructor(private el: ElementRef) {
    
  }
   
@Input( ) defaultwidth:number=100;
@Input() defaultheight:number=100;
@HostBinding('style.width') width: number;
 @HostListener('mouseover')
  private onmouseover() {
    this.elementSelected = !this.elementSelected;
        if (this.elementSelected) {

      this.el.nativeElement.width = this.el.nativeElement.width * 2;
      this.el.nativeElement.height = this.el.nativeElement.height * 2;
     
    }
   // alert(this.el.nativeElement.width + ', ' + this.el.nativeElement.height);
      }


  @HostListener('mouseleave')
  private onmouseleave() {
  //  this.elementSelected = !this.elementSelected;

  if (this.elementSelected) {

    this.el.nativeElement.width = this.defaultwidth;
    this.el.nativeElement.height = this.defaultheight;
 }
//alert(this.el.nativeElement.width + ', ' + this.el.nativeElement.height);
   
}









}