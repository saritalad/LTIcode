import { Directive,ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appHighlight]'
})
export class HighlightDirective {
  private elementSelected = false;
  constructor(private el:ElementRef) { 
    el.nativeElement.style.color='red';
  }

  @HostListener('mouseover')
  private onmouseover() {
    this.elementSelected = !this.elementSelected;
    if (this.elementSelected) {
      this.el.nativeElement.style.background='yellow';
    } else {
      this.el.nativeElement.style.background='white';
    }
  }
 



}
