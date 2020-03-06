import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NoticeOfWagesComponent } from './notice-of-wages.component';

describe('NoticeOfWagesComponent', () => {
  let component: NoticeOfWagesComponent;
  let fixture: ComponentFixture<NoticeOfWagesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NoticeOfWagesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NoticeOfWagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
