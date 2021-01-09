import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { RegistrationService } from '../registration.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(public service: RegistrationService, private tostr: ToastrService) { }

  ngOnInit(): void {
    this.service.formModel.reset();
  }

  onSubmit(){
    this.service.Register().subscribe(
      (res: any) => {
        if(res.succeeded){
          this.service.formModel.reset();
          this.tostr.success('New User Save', 'Registration Successfully');
        }
      },
      err => {
        this.tostr.error('Ragistration Faild', 'Please Provide Valid Information');
      },
      
    );
  }
}
