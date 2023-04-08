import { Component, OnInit } from '@angular/core';
import { StudentsService } from 'src/app/Services/students.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styles: [
  ]
})
export class StudentsComponent implements OnInit {
constructor(private mySrvice:StudentsService){}
Students:any;
  ngOnInit(): void {
    this.mySrvice.GetAllStudents().subscribe({
      next:(data)=>{
        // console.log(data)
        this.Students=data;
      },
      error:(err)=>{console.log(err)}
    })
  }
  delete(id:any)
  {
    this.mySrvice.DeleteStudentById(id).subscribe({
      next:()=>{
        this.Students.splice(+id-1,1);
      }
    })
  }
}
