import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BenefitChargeComponent } from './benefit-charge.component';

describe('BenefitChargeComponent', () => {
  let component: BenefitChargeComponent;
  let fixture: ComponentFixture<BenefitChargeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BenefitChargeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BenefitChargeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
