import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:5000/api";
readonly DetailEndPoint = "/detail";
readonly EmployeeEndPoint = "/employee";

  constructor(private http:HttpClient) { }

   
  getDetailsList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+this.DetailEndPoint); 
  }

  deleteDetail(val:any){
    return this.http.delete(this.APIUrl+this.DetailEndPoint+'/'+val) 
  }

  addDetail(val:any){
    return this.http.post(this.APIUrl+this.DetailEndPoint,val) 
  }

  updateDetail(val:any){
    return this.http.put(this.APIUrl+this.DetailEndPoint,val) 
  }



  getEmployeeNamesList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+this.EmployeeEndPoint); 
  }

  getEmployeesList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+this.EmployeeEndPoint+'/details'); 
  }

  deleteEmployee(val:any){
    return this.http.delete(this.APIUrl+this.EmployeeEndPoint+'/'+val) }
    
  addEmployee(val:any){
    return this.http.post(this.APIUrl+this.EmployeeEndPoint,val) 
  }

  updateEmployee(val:any){
    return this.http.put(this.APIUrl+this.EmployeeEndPoint,val) 
  }
}
