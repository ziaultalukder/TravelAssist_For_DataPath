import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from "@angular/common/http";


@Injectable({
  providedIn: 'root'
})
export class RegistrationService {

  constructor(private formBuilder: FormBuilder, private Http: HttpClient) { }

  formModel = this.formBuilder.group({
    UserName: ['', Validators.required],
    Email : ['', Validators.email],
    Password : ['', [Validators.required, Validators.minLength(4)]]
  })

  private BaseUrl = 'http://localhost:50139/api/';

  Register(){
    var body = {
      UserName: this.formModel.value.UserName,
      Email: this.formModel.value.Email,
      Password: this.formModel.value.Password,
    };

    return this.Http.post(this.BaseUrl+'Accounts/Registration', body);
  }
}
