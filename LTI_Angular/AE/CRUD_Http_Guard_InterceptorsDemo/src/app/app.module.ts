import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormGroup } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthModuleModule } from './auth-module/auth-module.module';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './auth.guard';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ReportComponent } from './report/report.component';
import { DemoPipe } from './demo.pipe';
import { CommonInterceptor } from './common.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,ReportComponent, DemoPipe
  ],
  imports: [
    BrowserModule,
    FormsModule , AppRoutingModule,AuthModuleModule,HttpClientModule
  ],
  providers: [{provide:HTTP_INTERCEPTORS,useClass:CommonInterceptor,multi:true}],
  bootstrap: [AppComponent]
})
export class AppModule { }
