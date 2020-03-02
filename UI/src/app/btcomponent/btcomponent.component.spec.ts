import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BtcomponentComponent } from './btcomponent.component';

describe('BtcomponentComponent', () => {
  let component: BtcomponentComponent;
  let fixture: ComponentFixture<BtcomponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BtcomponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BtcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
