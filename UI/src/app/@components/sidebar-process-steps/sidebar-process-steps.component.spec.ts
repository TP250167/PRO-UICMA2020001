import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SidebarProcessStepsComponent } from './sidebar-process-steps.component';

describe('SidebarProcessStepsComponent', () => {
  let component: SidebarProcessStepsComponent;
  let fixture: ComponentFixture<SidebarProcessStepsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SidebarProcessStepsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SidebarProcessStepsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
