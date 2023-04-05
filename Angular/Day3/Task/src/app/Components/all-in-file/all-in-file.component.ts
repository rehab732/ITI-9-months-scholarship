import { Component } from '@angular/core';

@Component({
  selector: 'app-all-in-file',
  templateUrl: './all-in-file.component.html',
  styleUrls: ['./all-in-file.component.css']
})
export class AllInFileComponent {
name="";
age="";
Students:{name:string,age:string}[]=[];
Add(){
  let newstudent={name:this.name,age:this.age};
  if(+this.age<=50&&(this.name!="")&&(this.age!=""))
  {
    this.Students.push(newstudent);
    this.name="";
    this.age="";
  }

}
}
