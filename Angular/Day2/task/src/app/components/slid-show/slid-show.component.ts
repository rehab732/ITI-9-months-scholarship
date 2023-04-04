import { Component } from '@angular/core';

@Component({
  selector: 'app-slid-show',
  templateUrl: './slid-show.component.html',
  styleUrls: ['./slid-show.component.css']
})
export class SlidShowComponent {
imageSrc="assets/images/1.jpg";
counter=1;
interval:any;

next(){
  this.counter++;
  if(this.counter<=5)
  {
    this.imageSrc=`assets/images/${this.counter}.jpg`;

  }
  if(this.counter>5)
  {
    this.counter=5;
  }

}
prev(){

this.counter--;
if(this.counter<=5&&this.counter>0)
{
  this.imageSrc=`assets/images/${this.counter}.jpg`;

}
if(this.counter<1)
{
  this.counter=1;
}


}
slid(){
  this.interval=setInterval(()=>{
    this.counter++;
    if(this.counter==5)
    {
      this.counter=1;
    }
    this.imageSrc=`assets/images/${this.counter}.jpg`;
  },1500);

}
stop(){
clearInterval(this.interval);
}
}
