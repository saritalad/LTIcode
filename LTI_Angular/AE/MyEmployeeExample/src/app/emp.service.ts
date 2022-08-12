import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { IEmployee } from './IEmployee';
@Injectable({
  providedIn: 'root'
})
export class EmpService {
url:string='http://localhost:3000/Employees';
  constructor(private http:HttpClient) { }

 getEmployees():Observable<any>
 {

  
  return this.http.get(this.url);

 }

AddEmployee(data:any):Observable<IEmployee>{

  return this.http.post<IEmployee>(this.url,data);

}
GetEmpById(id:number):Observable<IEmployee>
{
  return this.http.get<IEmployee>(`${this.url}/${id}`);
}


}
