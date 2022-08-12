import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { UserserviceService } from './userservice.service';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserlistComponent } from './userlist/userlist.component';
import { UserCardComponent } from './user-card/user-card.component';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { UserContactComponent } from './user-contact/user-contact.component';
import { UserOverViewComponent } from './user-over-view/user-over-view.component';
import { AddUserComponent } from './add-user/add-user.component';
import { FormsModule } from '@angular/forms';
import { EdituserComponent } from './edituser/edituser.component';
import { ReactiveFormsModule } from '@angular/forms';
@NgModule({
  declarations: [
    AppComponent,
    UserlistComponent,
    UserCardComponent,
    HomeComponent,
    NotFoundComponent,
    UserContactComponent,
    UserOverViewComponent,
    AddUserComponent,
    EdituserComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule,ReactiveFormsModule
  ],
  providers: [UserserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
