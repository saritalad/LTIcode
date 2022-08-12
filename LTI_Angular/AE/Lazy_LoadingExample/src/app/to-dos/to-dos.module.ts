import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ToDosRoutingModule } from './to-dos-routing.module';
import { ToDosComponent } from './to-dos.component';


@NgModule({
  declarations: [
    ToDosComponent
  ],
  imports: [
    CommonModule,
    ToDosRoutingModule
  ]
})
export class ToDosModule { }
