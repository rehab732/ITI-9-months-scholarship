import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StudentsComponent } from './Components/students/students.component';
import { AddStudentComponent } from './Components/add-student/add-student.component';
import { UpdateStudentComponent } from './Components/update-student/update-student.component';
import { ErrorComponent } from './Components/error/error.component';
import { StudentsDetailsComponent } from './Components/students-details/students-details.component';

const routes: Routes = [
  {path:"",redirectTo:"students",pathMatch:"full"},
  {path:"students",component:StudentsComponent},
  {path:"add",component:AddStudentComponent},
  {path:"update/:id",component:UpdateStudentComponent},
  {path:"student/:id",component:StudentsDetailsComponent},
  

  {path:"**",component:ErrorComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
