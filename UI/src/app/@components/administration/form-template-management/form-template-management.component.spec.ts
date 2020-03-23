import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormTemplateManagementComponent } from './form-template-management.component';

describe('FormTemplateManagementComponent', () => {
  let component: FormTemplateManagementComponent;
  let fixture: ComponentFixture<FormTemplateManagementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormTemplateManagementComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormTemplateManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
