import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
loginobj:any={
  Username:'',
  Password:''
}

constructor(private http:HttpClient,private router:Router) {}
    onLogin()
    {
     
      this.http.post('http://localhost:1592/api/Authentication/login',this.loginobj).subscribe((res:any)=>
      {
       debugger;
        if(res)
        {
          alert('login Successfull')
          localStorage.setItem('loginToken',res.token)
          this.router.navigateByUrl('dashboard')
           }
           else
           alert("not logged")
      })
    
}
}