import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-target-text',
  templateUrl: './target-text.component.html',
  styleUrls: ['./target-text.component.scss']
})
export class TargetTextComponent {
  @Input() TargetText : string = "";
}
