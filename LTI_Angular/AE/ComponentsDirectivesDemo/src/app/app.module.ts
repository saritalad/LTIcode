import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MystrdirectiveComponent } from './mystrdirective/mystrdirective.component';
import { MyAttrbtComponent } from './my-attrbt/my-attrbt.component';

@NgModule({
  declarations: [
    AppComponent,
    MystrdirectiveComponent,
    MyAttrbtComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
