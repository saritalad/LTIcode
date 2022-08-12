import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmpComponent } from './add-emp/add-emp.component';
import { EmpDetailsComponent } from './emp-details/emp-details.component';
import { EmpListComponent } from './emp-list/emp-list.component';
import { NotFoundComponent } from './not-found/not-found.component';

const routes: Routes = [
{path:'',component:EmpListComponent},
{path:'emplist',component:EmpListComponent},
{path:'add',component:AddEmpComponent},
{path:'details/:id',component:EmpDetailsComponent},
{path:'**',component:NotFoundComponent}




];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
