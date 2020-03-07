import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NoticeOfHearingComponent } from './notice-of-hearing.component';

describe('NoticeOfHearingComponent', () => {
  let component: NoticeOfHearingComponent;
  let fixture: ComponentFixture<NoticeOfHearingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NoticeOfHearingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NoticeOfHearingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
