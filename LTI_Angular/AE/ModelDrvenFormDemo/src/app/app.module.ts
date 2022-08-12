import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StaticComponent } from './static/static.component';
import { DynamicComponent } from './dynamic/dynamic.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { ProductComponent } from './product/product.component';
import { Observable } from 'rxjs/internal/Observable';
@NgModule({
  declarations: [
    AppComponent,
    StaticComponent,
    DynamicComponent,
    HomeComponent,
    ProductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,FormsModule,Observable
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
