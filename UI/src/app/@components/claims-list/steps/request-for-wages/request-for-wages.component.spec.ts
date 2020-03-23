import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestForWagesComponent } from './request-for-wages.component';

describe('RequestForWagesComponent', () => {
  let component: RequestForWagesComponent;
  let fixture: ComponentFixture<RequestForWagesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RequestForWagesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RequestForWagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
