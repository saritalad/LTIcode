import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AppUser } from '../AppUser';
import { AuthService } from '../auth.service';
@Component({
  selector: 'register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  user: AppUser = {
    firstName: '', lastName: '', password: '', email: '', securityQuestion: '', securityAnswer: ''
  };

  public questions: string[] = [
    'what is name of first school attended?',
    'what is name of childhood friend?',
    'what is fav color?',
  ]

  Isregistered = false;
  constructor(private _userservice: AuthService, private router: Router) { }
  onSubmit(login: any) {

    console.log(this.user);
    console.log(login);
    this._userservice.RegisterUser(login)
      .subscribe(
        response => {
          console.log(response);
         //alert('done!')
          this.Isregistered = true;
          this.router.navigate(['/report']);
        },
        error => {
          console.log(error);
        },
      );
    

  }



}