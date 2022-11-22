import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChildComponent } from './child/child.component';
import { GrandchildComponent } from './grandchild/grandchild.component';
import { HomeComponent } from './home/home.component';
import { Child1Component } from './child1/child1.component';
import { Grandchild2Component } from './grandchild2/grandchild2.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ChildComponent,
    GrandchildComponent,
    HomeComponent,
    Child1Component,
    Grandchild2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
