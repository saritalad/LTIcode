import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { FormGroup } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    RegisterComponent,
    LoginComponent
  ],
  exports: [
   RegisterComponent,LoginComponent
  ],
  imports: [
    CommonModule,FormsModule,HttpClientModule
  ]
})

export class AuthModuleModule { }
