import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { EmployeeComponent } from './employee/employee.component';
import { AddEditEmpComponent } from './employee/add-edit-emp/add-edit-emp.component';
import { ShowEmpComponent } from './employee/show-emp/show-emp.component';
import { SharedService } from './shared.service';

import {HttpClientModule} from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { DetailComponent } from './detail/detail.component';
import { ShowDetComponent } from './detail/show-det/show-det.component';
import { AddEditDetComponent } from './detail/add-edit-det/add-edit-det.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    AddEditEmpComponent,
    ShowEmpComponent,
    DetailComponent,
    ShowDetComponent,
    AddEditDetComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule, 
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
