import { Component, OnInit } from '@angular/core';
import { TouristPlaceService } from '../tourist-place.service';

@Component({
  selector: 'app-tourist-place-details',
  templateUrl: './tourist-place-details.component.html',
  styleUrls: ['./tourist-place-details.component.css']
})
export class TouristPlaceDetailsComponent implements OnInit {

  constructor(private service: TouristPlaceService) { }

  ngOnInit(): void {
    this.service.GetAll();
  }

}
