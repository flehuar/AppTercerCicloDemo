import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';


import { LoginRequest } from 'src/app/models/login-request';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginRequest: LoginRequest = new LoginRequest();
  myForm: FormGroup;
  constructor(
    private toastr: ToastrService,
    private fb: FormBuilder,
    private _router: Router
  ) {

    this.myForm = this.fb.group({
      username: [null, [Validators.required, Validators.email]],
      password: [null, [Validators.required]],
    });

  }

  ngOnInit(): void {
    // this.toastr.success('Hello world!', 'Toastr fun!');
  }

  acceder() {

    // this.loginRequest = this.myForm.value; ==> cuando uno de los controles esta en disabled / no muestra ese valor
    this.loginRequest = this.myForm.getRawValue();

    if(!(this.loginRequest.username == "fhuaman@continental.edu.pe" && this.loginRequest.password=="123456"))
    {
      this.toastr.error('Usuario o password incorrecto', 'Error!');
      return;
    }

    this.toastr.success('Acceso correcto', 'Excelente!');

    setTimeout(() => {
      this._router.navigate(["dashboard"]);
    }, 500);


  }



}
