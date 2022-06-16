import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowDetComponent } from './show-det.component';

describe('ShowDetComponent', () => {
  let component: ShowDetComponent;
  let fixture: ComponentFixture<ShowDetComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowDetComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowDetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
