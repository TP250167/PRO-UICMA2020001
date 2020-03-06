import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResponseToEmployerComponent } from './response-to-employer.component';

describe('ResponseToEmployerComponent', () => {
  let component: ResponseToEmployerComponent;
  let fixture: ComponentFixture<ResponseToEmployerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResponseToEmployerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResponseToEmployerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
