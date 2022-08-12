import { HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse,HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { catchError, throwError } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
url :string= 'http://localhost:3000/users';


  constructor(private http:HttpClient) { }
 
  
  RegisterUser(data:any): Observable<any>
  {
   return this.http.post(this.url,data);//.pipe(catchError(this.handleError));
  }
  LoginUser(username:string):Observable<any>
  {
    return this.http.get(`${this.url}/${username}`);
  }
  
  handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
    } else {
      console.error(
        `Backend returned code ${error.status}, ` +`body was: ${error.error}`);
    }
    return throwError(
      'Something bad happened; please try again later.');
  };
  
  list(): Observable<any> {
    return this.http.get(this.url).pipe(
      catchError(this.handleError)
    );
  }
 
 

}
