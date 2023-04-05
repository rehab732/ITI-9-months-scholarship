import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // title = 'Task';
  // ParentData="hello";
  // datafromlogin="";

  //students:{name:string;age:any}[]=[];
  // getStudentData(student:any)
  // {
  //   this.students.push(student);
  // }
  students:{[key:string]:any}=[];
  getStudentData(student:any)
  {
    this.students['push'](student);
  }

}
