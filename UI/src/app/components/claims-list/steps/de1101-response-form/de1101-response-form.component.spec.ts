import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { De1101ResponseFormComponent } from './de1101-response-form.component';

describe('De1101ResponseFormComponent', () => {
  let component: De1101ResponseFormComponent;
  let fixture: ComponentFixture<De1101ResponseFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ De1101ResponseFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(De1101ResponseFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
