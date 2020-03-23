import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClaimInitComponent } from './claim-init.component';

describe('ClaimInitComponent', () => {
  let component: ClaimInitComponent;
  let fixture: ComponentFixture<ClaimInitComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClaimInitComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClaimInitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
