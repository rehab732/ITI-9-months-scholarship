import { Component,EventEmitter,Output } from '@angular/core';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent {
// name="";
// age="";
// @Output() event=new EventEmitter();
// constructor(){}
// addstudent(event:any){
//   if(this.name.length>3 && +this.age<40 && +this.age>20  )
//   {
//     this.event.emit({
//       name:this.name,
//       age:this.age,
      
//     });

//   }
// }
 validation=false;
 studentname="";
 studentAge="";
 @Output() studentEvent=new EventEmitter();
  addStudent(event:any)
  {
    event.preventDefault();
    if(+this.studentAge>20&&+this.studentAge<40&&this.studentname.length>3)
    {
      this.validation=false;
      const student={name:this.studentname,age:this.studentAge};
      this.studentEvent.emit(student);
    }else{

      this.validation=true
    }
    

  }


}
