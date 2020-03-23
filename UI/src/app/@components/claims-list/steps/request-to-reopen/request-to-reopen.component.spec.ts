import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestToReopenComponent } from './request-to-reopen.component';

describe('RequestToReopenComponent', () => {
  let component: RequestToReopenComponent;
  let fixture: ComponentFixture<RequestToReopenComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RequestToReopenComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RequestToReopenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
