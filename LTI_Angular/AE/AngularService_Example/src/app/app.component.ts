import { Component, TemplateRef } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'empService_Example';
 public show:boolean=false;
 thenBlock: TemplateRef<any>|null = null;
}
