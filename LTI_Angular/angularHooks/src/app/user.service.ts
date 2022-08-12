import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class UserService {
url:string="http://localhost:3000/users";
  constructor(private http:HttpClient) { }

    getusers():Observable<any>
    {
     return this.http.get(this.url);
    }


}
