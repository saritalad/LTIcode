import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddUserComponent } from './add-user/add-user.component';
import { EdituserComponent } from './edituser/edituser.component';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { UserCardComponent } from './user-card/user-card.component';
import { UserContactComponent } from './user-contact/user-contact.component';
import { UserOverViewComponent } from './user-over-view/user-over-view.component';
import { UserlistComponent } from './userlist/userlist.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'userlist', component: UserlistComponent },
  //   {path:'userlist/:id',component:UserCardComponent,
  // children:[

  //   {path:'OverView',component:UserOverViewComponent},
  //   {path:'Contact',component:UserContactComponent}
  // ]
  //},
  { path: 'userlist/edit/:id', component:EdituserComponent },
  { path: 'addnew', component: AddUserComponent },
  { path: 'home', component: HomeComponent },
  { path: "**", component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
