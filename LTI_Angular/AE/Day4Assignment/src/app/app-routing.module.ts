import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from './add/add.component';
import { EditComponent } from './edit/edit.component';
import { UpdateComponent } from './update/update.component';
import { UserlistComponent } from './userlist/userlist.component';

const routes: Routes = [
  {path:'',component:UserlistComponent},
  {path:'add',component:AddComponent},
  {path:'edit/:id',component:EditComponent},
  {path:'userlist',component:UserlistComponent},
  {path:'update/:id',component:UpdateComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
