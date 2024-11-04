import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
url:string ="https://localhost:44360/api/user";
//myWeb_APIDemo LTI BATCH1046 MYWebAPI_LogIn_Batch1046
  constructor(private http:HttpClient) { }
// this method authenticate user by entering email and password using user object
  AuthenticateUser(user:any):Observable<any>
{

return this.http.post<any>(this.url+"/Authenticate",user,{observe:'response'});
}




}
