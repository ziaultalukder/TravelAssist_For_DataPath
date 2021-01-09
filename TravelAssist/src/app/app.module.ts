import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms'
import { HttpClientModule } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './registration/registration.component';
import { TouristPlaceComponent } from './tourist-place/tourist-place.component';
import { RegistrationService } from './registration.service';
import { LoginComponent } from './login/login.component';
import { LoginService } from './login.service';
import { TouristPlaceDetailsComponent } from './tourist-place-details/tourist-place-details.component';

@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponent,
    TouristPlaceComponent,
    LoginComponent,
    TouristPlaceDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [RegistrationService, LoginService],
  bootstrap: [AppComponent]
})
export class AppModule { }
