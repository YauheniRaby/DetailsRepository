import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditDetComponent } from './add-edit-det.component';

describe('AddEditDetComponent', () => {
  let component: AddEditDetComponent;
  let fixture: ComponentFixture<AddEditDetComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditDetComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddEditDetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
