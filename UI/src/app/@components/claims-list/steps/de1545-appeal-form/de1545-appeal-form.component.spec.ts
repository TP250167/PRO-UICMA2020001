import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DE1545AppealFormComponent } from './de1545-appeal-form.component';

describe('DE1545AppealFormComponent', () => {
  let component: DE1545AppealFormComponent;
  let fixture: ComponentFixture<DE1545AppealFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DE1545AppealFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DE1545AppealFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
