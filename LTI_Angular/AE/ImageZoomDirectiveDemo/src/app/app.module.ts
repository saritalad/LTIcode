import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ImageZoomComponent } from './image-zoom/image-zoom.component';

import { MagnifyDirective } from './magnify.directive';

@NgModule({
  declarations: [
    AppComponent,
    ImageZoomComponent,
 
    MagnifyDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
