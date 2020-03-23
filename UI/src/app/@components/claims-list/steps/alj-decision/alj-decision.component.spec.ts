import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AljDecisionComponent } from './alj-decision.component';

describe('AljDecisionComponent', () => {
  let component: AljDecisionComponent;
  let fixture: ComponentFixture<AljDecisionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AljDecisionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AljDecisionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
