import { Component } from '@angular/core';
import {FormControl,Validators, FormGroup} from '@angular/forms';

@Component({
  selector: 'app-validation-form',
  templateUrl: './validation-form.component.html',
  styleUrls: []
})
export class ValidationFormComponent {
  formValidation=new FormGroup({
    name:new FormControl("Rehab",[Validators.required,Validators.minLength(3)]),
    age:new FormControl(22,[Validators.required,Validators.min(20),Validators.max(40)]),
    email:new FormControl("test@gmail.com",[Validators.required,Validators.email])
  })
  get NameValid(){
    return this.formValidation.controls["name"].valid;
  }
  get AgeValid(){
    return this.formValidation.controls["age"].valid;
  } get EmailValid(){
    return this.formValidation.controls["email"].valid;
  }
  getvalue(){

  }
}
