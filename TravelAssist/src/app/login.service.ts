import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private LoginUrl = '';

  constructor(private formBuilder: FormBuilder, private Http: HttpClient) { }

  formModel = this.formBuilder.group({
    Email : ['', Validators.email],
    Password : ['', [Validators.required, Validators.minLength(4)]]
  })



}
