import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-emp',
  templateUrl: './add-edit-emp.component.html',
  styleUrls: ['./add-edit-emp.component.css']
})
export class AddEditEmpComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() Employee:any;

  ngOnInit(): void {
  }

  addEmployee(){
    var result = {name:this.Employee.name};
    this.service.addEmployee(result).subscribe(res=>{
      alert('Added');
      });
  }

  updateEmployee(){
    var result = {id:this.Employee.id,
                name:this.Employee.name};
    this.service.updateEmployee(result).subscribe(res=>{
      alert('Updated'); 
    });
  }

}
