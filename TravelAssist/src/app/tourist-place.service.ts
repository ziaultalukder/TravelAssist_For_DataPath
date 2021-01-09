import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { TouristPlace } from './TouristPlace';

@Injectable({
  providedIn: 'root'
})
export class TouristPlaceService {
  private BaseUrl = 'http://localhost:50139/api/';
  constructor(private formBuilder: FormBuilder, private Http: HttpClient) { }

  TouristPlacelist: TouristPlace[];

  formModel = this.formBuilder.group({
    Title : ['', Validators.email],
    Description : ['', [Validators.required]]
  })

  Create(){
    var body = {
      Title: this.formModel.value.Title,
      Description: this.formModel.value.Description,
    };

    return this.Http.post(this.BaseUrl+'TouristPlace/Post', body);
  }

  GetAll(){
    this.Http.get(this.BaseUrl+'TouristPlace')
    .toPromise()
    .then( respons => this.TouristPlacelist = respons as TouristPlace[]);
  }
  
}
