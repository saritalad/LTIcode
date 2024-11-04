import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class CustomInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
   debugger;
   const token=localStorage.getItem('loginToken')
   const newclonerequest=request.clone({
setHeaders:{
  Authorization:`bearer ${token}`
}
   
   })
    return next.handle(newclonerequest);
  }
}
