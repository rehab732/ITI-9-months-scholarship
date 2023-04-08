import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  constructor( private readonly myClient:HttpClient) { }
  private readonly DB_Url="http://localhost:3000/students";

  GetAllStudents(){
    return this.myClient.get(this.DB_Url);
  }

  GetStudentById(id:any){
    return this.myClient.get(this.DB_Url+"/"+id);
  }
  AddNewStudent(newstudent:any){
    return this.myClient.post(this.DB_Url,newstudent);
  }
  UpdateStudent(id:any,updatedstudent:any)
  {
    return this.myClient.put(this.DB_Url+"/"+id,updatedstudent);
  }

  DeleteStudentById(id:any){
    return this.myClient.delete(this.DB_Url+"/"+id);
  }
}
