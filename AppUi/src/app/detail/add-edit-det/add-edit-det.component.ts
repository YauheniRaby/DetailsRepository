import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { Employee } from 'src/models/employee'

@Component({
  selector: 'app-add-edit-det',
  templateUrl: './add-edit-det.component.html',
  styleUrls: ['./add-edit-det.component.css']
})
export class AddEditDetComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() detail:any;
  
  Employee:any;

  EmployeeList:Employee[];

  ngOnInit(): void {    
    this.loadEmployeeNamesList(); 
  }

  addDetail(){
    var result = {vendorCode:this.detail.vendorCode,
              name:this.detail.name,
              count:this.detail.count,
              employeeId:this.Employee.id};
    this.service.addDetail(result).subscribe(res=>{
      alert('Added successfully');
      }, 
      error => console.log('Status code: '+error.status));
  }

  updateDetail(){
    var result = {id:this.detail.id,
      vendorCode:this.detail.vendorCode,
      name:this.detail.name,
      count:this.detail.count,
      employeeId:this.Employee.id};
    this.service.updateDetail(result).subscribe(res=>{
      alert('Updated successfully'); 
    }, 
    error => console.log('Status code: '+error.status));
  }

  loadEmployeeNamesList(){
    this.service.getEmployeeNamesList().subscribe(res=>{
      this.EmployeeList=res;             
      if (this.detail.employee != undefined) 
      {
        this.Employee = this.EmployeeList.find(x => (x.id == this.detail.employee.id));
      }           
    }, 
    error => console.log('Status code: '+error.status))
  }  
}
