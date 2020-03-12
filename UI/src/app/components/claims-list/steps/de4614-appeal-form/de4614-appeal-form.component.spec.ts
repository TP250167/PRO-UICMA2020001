import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { De4614AppealFormComponent } from './de4614-appeal-form.component';

describe('De4614AppealFormComponent', () => {
  let component: De4614AppealFormComponent;
  let fixture: ComponentFixture<De4614AppealFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ De4614AppealFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(De4614AppealFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
