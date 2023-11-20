import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-gauge',
  templateUrl: './gauge.component.html',
  styleUrls: ['./gauge.component.scss']
})
export class GaugeComponent {
  //Source : https://www.fullstacklabs.co/blog/creating-an-svg-gauge-component-from-scratch
  @Input() radius:number=200;
  @Input() percentFill:number=0
  strokeWidth = this.radius * 0.2;
  innerRadius = this.radius - this.strokeWidth / 2;
  circumference = this.innerRadius * 2 * Math.PI;
  arc = this.circumference * (270 / 360);
  rotation = `rotate(135,${this.radius},${this.radius})`
  dashArrayTrick=`${this.arc} ${this.circumference}`

  constructor(){
    
  }

}
