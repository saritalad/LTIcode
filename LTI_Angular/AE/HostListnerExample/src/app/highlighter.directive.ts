import { Directive, HostBinding, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[Highlighter]'
})
export class HighlighterDirective {

  constructor() { }
  @Input() defaultColor: string = 'transparent';
  @Input('Highlighter') highlightColor: string = ' ';
  @HostBinding('style.backgroundColor') backgroundColor: string;
  @HostListener('mouseenter')
  mouseover(eventData: Event) {
    this.backgroundColor = this.highlightColor;
  }
  @HostListener('mouseleave') mouseleave(eventData: Event) {
    this.backgroundColor = this.defaultColor;
  }
}
