import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ValidationFormComponent } from './Components/validation-form/validation-form.component';
import { StudentsComponent } from './Components/students/students.component';
import { StudentDetailsComponent } from './Components/student-details/student-details.component';
import { ErrorComponent } from './Components/error/error.component';
import { HeaderComponent } from './Components/header/header.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    ValidationFormComponent,
    StudentsComponent,
    StudentDetailsComponent,
    ErrorComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      {path:"",component:ValidationFormComponent},
      {path:"home",component:ValidationFormComponent},
      {path:"students",component:StudentsComponent},
      {path:"students/:id",component:StudentDetailsComponent},
      {path:"**",component:ErrorComponent},


    ]),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
