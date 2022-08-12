import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MypipePipe } from './mypipe.pipe';
import { EmpListComponent } from './emp-list/emp-list.component';
import { AddEmpComponent } from './add-emp/add-emp.component';
import { EmpDetailsComponent } from './emp-details/emp-details.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { FormsModule } from '@angular/forms';
import { LoggingInterceptor } from './logging.interceptor';


@NgModule({
  declarations: [
    AppComponent,
    MypipePipe,
    EmpListComponent,
    AddEmpComponent,
    EmpDetailsComponent,
    NotFoundComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule
  ],
  providers: [
{provide:HTTP_INTERCEPTORS,useClass:LoggingInterceptor,multi:true}

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
