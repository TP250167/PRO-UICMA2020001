import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { De1101InterviewComponent } from './de1101-interview.component';

describe('De1101InterviewComponent', () => {
  let component: De1101InterviewComponent;
  let fixture: ComponentFixture<De1101InterviewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ De1101InterviewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(De1101InterviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
