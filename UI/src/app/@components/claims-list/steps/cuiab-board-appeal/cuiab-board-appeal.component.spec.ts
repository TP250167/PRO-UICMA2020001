import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CuiabBoardAppealComponent } from './cuiab-board-appeal.component';

describe('CuiabBoardAppealComponent', () => {
  let component: CuiabBoardAppealComponent;
  let fixture: ComponentFixture<CuiabBoardAppealComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CuiabBoardAppealComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CuiabBoardAppealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
