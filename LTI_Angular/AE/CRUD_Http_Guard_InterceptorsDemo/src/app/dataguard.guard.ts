import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Resolve, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AppUser } from './auth-module/AppUser';

@Injectable({
  providedIn: 'root'
})
export class DataguardGuard implements Resolve<AppUser>
 {
  user:AppUser={firstName:'sarita',lastName:'lad',email:'',securityQuestion:'',securityAnswer:'',password:''};
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): AppUser | Observable<AppUser> | Promise<AppUser> {
    return this.user;
  }
  
  
}
