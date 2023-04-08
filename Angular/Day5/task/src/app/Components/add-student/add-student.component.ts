import { Component } from '@angular/core';
import { StudentsService } from 'src/app/Services/students.service';

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styles: [
  ]
})
export class AddStudentComponent {
  constructor(private myService:StudentsService){}
  AddStudent(n:any,a:any,p:any,e:any,c:any){
let newStudent={name:n,age:a,phone:p,email:e,course:c};
this.myService.AddNewStudent(newStudent).subscribe();
  }
}
