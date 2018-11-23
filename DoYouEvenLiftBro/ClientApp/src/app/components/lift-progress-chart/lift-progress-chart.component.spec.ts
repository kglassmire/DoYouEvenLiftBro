import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LiftProgressChartComponent } from './lift-progress-chart.component';

describe('LiftProgressChartComponent', () => {
  let component: LiftProgressChartComponent;
  let fixture: ComponentFixture<LiftProgressChartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LiftProgressChartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LiftProgressChartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
