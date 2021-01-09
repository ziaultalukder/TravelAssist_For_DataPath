import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { TouristPlaceService } from '../tourist-place.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, RouterModule, Routes } from '@angular/router';


@Component({
  selector: 'app-tourist-place',
  templateUrl: './tourist-place.component.html',
  styleUrls: ['./tourist-place.component.css']
})
export class TouristPlaceComponent implements OnInit {
  

  constructor(public touristService: TouristPlaceService, private Http: HttpClient, private tostr: ToastrService, private router: Router) { }

  ngOnInit(): void {
  }

  onSubmit(){
    this.touristService.Create().subscribe(
      (res: any) => {
        this.touristService.formModel.reset();
        this.router.navigate(['TouristPlaces'])
      },
      err => {
        console.log(err);
        this.tostr.error('Added Faild', 'Please Provide Valid Information');
      },
      
    );
  }
}
