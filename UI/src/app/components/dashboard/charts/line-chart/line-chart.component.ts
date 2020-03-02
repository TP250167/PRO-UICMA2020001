import { Component, OnInit , ViewChild} from '@angular/core';

import { ChartDataSets, ChartOptions } from 'chart.js';
import { Color, Label } from 'ng2-charts';

@Component({
  selector: 'app-line-chart',
  templateUrl: './line-chart.component.html',
  styleUrls: ['./line-chart.component.scss']
})
export class LineChartComponent implements OnInit {

  public lineChartData: ChartDataSets[] = [
    { data: [65, 59, 80, 81, 56, 55, 40], label: 'Series A' ,borderWidth: [1]},
  ];
  public lineChartLabels: Label[] = ['January', 'February', 'March', 'April', 'May', 'June', 'July'];
 
  public lineChartOptions: ChartOptions = { responsive: true, };
  
  public lineChartColors: Color[] = [
    {
      borderColor: '#5e72e4',
      backgroundColor: 'rgba(94, 114, 227, 0.75)',
    },
  ];
  public lineChartLegend = true;
  public lineChartType = 'line';
  public lineChartPlugins = [];



  constructor() { }

  ngOnInit() {
  }

}
