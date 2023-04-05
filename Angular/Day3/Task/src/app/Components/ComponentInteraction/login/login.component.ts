import { Component,EventEmitter,Output } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  LoginData="mmmmm";
 constructor(){
  setTimeout(()=>{
    this.myEvent.emit(this.LoginData);
  },3000)
 }


  @Output()myEvent=new EventEmitter();
}
