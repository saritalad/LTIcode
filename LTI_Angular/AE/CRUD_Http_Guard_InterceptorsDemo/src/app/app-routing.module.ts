import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './auth-module/login/login.component';
import { RegisterComponent } from './auth-module/register/register.component';

import { HomeComponent } from './home/home.component';
import { ReportComponent } from './report/report.component';


const routes: Routes = [
  {path:'',component:HomeComponent},
{path:'login',component:LoginComponent},
{path:'register/:id',component:RegisterComponent},
{path:'report',component:ReportComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
