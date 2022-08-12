import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      let isAuthenticated=localStorage.getItem('loggedIn');

    // let username = prompt("enter your user name");
    // let password = prompt("enter password");
  //  if (username == 'admin' && password == 'admin')
  //  return true;
  //  else 
  //  return false;
// if(isAuthenticated)
//       return true;
//     else
//       return false;
return true;
   }

}
