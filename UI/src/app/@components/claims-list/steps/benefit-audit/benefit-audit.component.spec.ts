import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BenefitAuditComponent } from './benefit-audit.component';

describe('BenefitAuditComponent', () => {
  let component: BenefitAuditComponent;
  let fixture: ComponentFixture<BenefitAuditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BenefitAuditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BenefitAuditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
