import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-students-item',
  templateUrl: './students-item.component.html',
  styles: [
  ]
})
export class StudentsItemComponent {
 
  @Input() students:any;
}

