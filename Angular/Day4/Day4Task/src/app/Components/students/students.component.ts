import { Component } from '@angular/core';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent {
   students = [
    {
      name: "Alice",
      age: 18,
      email: "alice@example.com"
    },
    {
      name: "Bob",
      age: 19,
      email: "bob@example.com"
    },
    {
      name: "Charlie",
      age: 20,
      email: "charlie@example.com"
    },
    {
      name: "David",
      age: 21,
      email: "david@example.com"
    },
    {
      name: "Eve",
      age: 22,
      email: "eve@example.com"
    },
    {
      name: "Frank",
      age: 23,
      email: "frank@example.com"
    },
    {
      name: "Grace",
      age: 24,
      email: "grace@example.com"
    },
    {
      name: "Harry",
      age: 25,
      email: "harry@example.com"
    },
    {
      name: "Ivy",
      age: 26,
      email: "ivy@example.com"
    },
    {
      name: "Jack",
      age: 27,
      email: "jack@example.com"
    }
  ];
  
}
