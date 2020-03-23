import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppealFormComponent } from './appeal-form.component';

describe('AppealFormComponent', () => {
  let component: AppealFormComponent;
  let fixture: ComponentFixture<AppealFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppealFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppealFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
