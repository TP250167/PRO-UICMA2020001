import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NoticeOfDeterminationComponent } from './notice-of-determination.component';

describe('NoticeOfDeterminationComponent', () => {
  let component: NoticeOfDeterminationComponent;
  let fixture: ComponentFixture<NoticeOfDeterminationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NoticeOfDeterminationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NoticeOfDeterminationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
