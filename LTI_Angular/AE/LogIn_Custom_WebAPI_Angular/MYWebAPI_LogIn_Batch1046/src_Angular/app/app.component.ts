import { Component } from '@angular/core';
import { user } from 'src/Models/user';
import { LoginService } from './login.service';

@Component( {
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
} )
export class AppComponent {
  title = 'LOGIN_Angular_Client';
//loginuser:user={userid:0,email:"",password:""};
constructor(private _service:LoginService) {
  
}

  onSubmit(form:any)
  {   let loginuser=form.value;
    this._service.AuthenticateUser(loginuser).subscribe(
      (data)=>
      {  
      if(data.status==200)
      {
      
      alert("login success");
    //  console.log(data);
      }
      },(err:any)=>
      {
      alert("There was a problem logging "+err.message);
      
      });
}
}