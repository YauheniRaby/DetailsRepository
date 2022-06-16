import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-emp',
  templateUrl: './show-emp.component.html',
  styleUrls: ['./show-emp.component.css']
})
export class ShowEmpComponent implements OnInit {

  constructor(private service:SharedService) { }

  EmployeesList:any=[];

  Employee:any;  
  ActivateAddEditEmpComp:boolean=false;
  ModalTitle:string='';

  ngOnInit(): void {
    this.refreshEmployeeList();
  }

  refreshEmployeeList(){
    this.service.getEmployeesList().subscribe(data=>{
      this.EmployeesList=data;
    })
  }

  deleteClick(item:any){
    if(confirm('Are you sure??')){
      this.service.deleteEmployee(item.id).subscribe(()=>{        
        this.refreshEmployeeList();
      })      
    }
  }

  editClick(dataItem:any){
    this.Employee=dataItem;
    this.ModalTitle="Edit Employee";
    this.ActivateAddEditEmpComp=true
  }

  closeClick(){
    this.ActivateAddEditEmpComp=false;
    this.refreshEmployeeList();
  }

  addClick(){
    this.Employee={
      id:0,
      name:""
    }
    this.ModalTitle="Add Employee";
    this.ActivateAddEditEmpComp=true;
  }
}
