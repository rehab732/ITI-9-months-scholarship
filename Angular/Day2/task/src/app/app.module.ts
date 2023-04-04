import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FirstComponent } from './components/FirstComponent/first.component';
import { SecondComponentComponent } from './components/second-component/second-component.component';
import { FormsModule } from '@angular/forms';
import { BindingComponent } from './components/binding/binding.component';
import { SlidShowComponent } from './components/slid-show/slid-show.component';
//Decorator
@NgModule({
  declarations: [
    AppComponent,
    FirstComponent,
    SecondComponentComponent,
    BindingComponent,
    SlidShowComponent
    /*
    //here we declare any
    1-component
    2-pipes
    3-directives
    */
  ],
  imports: [
    BrowserModule,
    FormsModule,
    /*
    here we put
    4-external module
     [httpclientmodule,
       router module,
       formsmodules-....]
    */ 
    AppRoutingModule
  ],
  providers: [
    /**
     * 5-put on it services
     */
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
