import {Component} from "@angular/core";

@Component ({
    selector:"app-first",
    templateUrl:"./first.component.html",
    styleUrls:["./first.component.css"]
})
export class FirstComponent{
    name="Rehab";
    word="";
    lname="";
    imageSrc="assets/images/gh.jpg";
     change() {
        this.name="Mahmouud";
        this.imageSrc="assets/images/bb.jpg"
    }
    typing(e:any)
    {
        this.word=e.target.value;

    }
}