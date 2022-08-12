import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserlistComponent } from './userlist/userlist.component';
 import { HttpClientModule } from '@angular/common/http';
 import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AddComponent } from './add/add.component';
import { DeleteComponent } from './delete/delete.component';
import { EditComponent } from './edit/edit.component';
import { UpdateComponent } from './update/update.component';


// import { Observable } from 'rxjs';
@NgModule({
  declarations: [
    AppComponent,
  UserlistComponent,
  AddComponent,
  DeleteComponent,
  EditComponent,
  UpdateComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule,ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
