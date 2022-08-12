import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable} from 'rxjs/internal/Observable';
import { IUser } from './user';
import { catchError } from 'rxjs/operators';



@Injectable({
  providedIn: 'root'
})
export class UserService {
 // private url:string='assets/DB.json';
 url:string='http://localhost:3000/users'; 
// get post put and delete 
 //headers = new HttpHeaders().set('Content-Type', 'application/json').set('Accept', 'application/json');
 //users :any[]=[];
  constructor(private http:HttpClient) { }
  
  getUsers() :Observable<any[]>
  {
    return this.http.get<any>(this.url);
     
  }
 getuserById(id:number):Observable<any>
 {
   return this.http.get<any>(`${this.url}/${id}`);
 }
 

AddUser(data:any):Observable<any>
{
  let API_Url=this.url;
  return this.http.post(API_Url,data);

}
update(data: any): Observable<any> {
  let API_Url=this.url;
  return this.http.put(API_Url, data).pipe(
    catchError(this.handleError)
  )
}

delete(id: any): Observable<any> {
  let API_Url=this.url;
  return this.http.delete(API_Url).pipe(
    catchError(this.handleError)
  )
}

   
handleError(error: HttpErrorResponse) {
  if (error.error instanceof ErrorEvent) {
    console.error('An error occurred:', error.error.message);
  } else {
    console.error(
      `Backend returned code ${error.status}, ` +
      `body was: ${error.error}`);
  }
  return (
    'Something bad happened; please try again later.');
};



}
