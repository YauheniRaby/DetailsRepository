import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-det',
  templateUrl: './show-det.component.html',
  styleUrls: ['./show-det.component.css']
})
export class ShowDetComponent implements OnInit {

  constructor(private service:SharedService) { }

  DetailsList:any=[];

  detail:any;  
  ActivateAddEditDetComp:boolean=false;
  ModalTitle:string='';


  ngOnInit(): void {
    this.refreshDetailList();
  }

  refreshDetailList(){
    this.service.getDetailsList().subscribe(data=>{
      this.DetailsList=data;
    },
    error => console.log(error.status))
  }

  addClick(){
    this.detail={
      id:0,
      name:""
    }
    this.ModalTitle="Add Detail";
    this.ActivateAddEditDetComp=true;
  }

  deleteClick(item:any){
    if(confirm('Are you sure??')){
      this.service.deleteDetail(item.id).subscribe(()=>{        
        this.refreshDetailList();
        alert('Deleted successfully');
      },
      error => console.log(error.status))      
    }    
  }

  editClick(dataItem:any){
    this.detail=dataItem;
    this.ModalTitle="Edit Detail";
    this.ActivateAddEditDetComp=true
  }

  closeClick(){
    this.ActivateAddEditDetComp=false;
    this.refreshDetailList();
  }
}
