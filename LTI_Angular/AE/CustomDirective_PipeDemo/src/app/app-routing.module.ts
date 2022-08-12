import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutusComponent } from './aboutus/aboutus.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { UserlistComponent } from './userlist/userlist.component';

const routes: Routes = [
  {path:'',redirectTo:'/userlist',pathMatch:'full'},
{path:'userlist',component:UserlistComponent},
{path:'aboutus',component:AboutusComponent},
{path:'**',component:NotFoundComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
 export  const rountingComponent=[UserlistComponent,AboutusComponent,NotFoundComponent];