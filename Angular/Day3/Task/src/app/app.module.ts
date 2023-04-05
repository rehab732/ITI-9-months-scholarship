import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllInFileComponent } from './Components/all-in-file/all-in-file.component';
import { HomeComponent } from './Components/ComponentInteraction/home/home.component';
import { LoginComponent } from './Components/ComponentInteraction/login/login.component';
import { RegistrationComponent } from './Components/registration/registration.component';
import { StudentsComponent } from './Components/students/students.component';

@NgModule({
  declarations: [
    AppComponent,
    AllInFileComponent,
    HomeComponent,
    LoginComponent,
    RegistrationComponent,
    StudentsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
