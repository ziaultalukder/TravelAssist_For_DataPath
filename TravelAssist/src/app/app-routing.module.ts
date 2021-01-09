import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { TouristPlaceDetailsComponent } from './tourist-place-details/tourist-place-details.component';
import { TouristPlaceComponent } from './tourist-place/tourist-place.component';

const routes: Routes = [
  { path: '', redirectTo:'/tourist-place', pathMatch:'full' },
  {path: 'Registration', component: RegistrationComponent},
  { path: 'Login', component: LoginComponent },
  {path: 'TouristPlace', component: TouristPlaceComponent},
  { path: '**', component: TouristPlaceDetailsComponent },
  { path: 'TouristPlaces', component: TouristPlaceDetailsComponent },
  { path: 'Edit/:Id', component: TouristPlaceDetailsComponent }
  
    
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
