import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-target-text',
  templateUrl: './target-text.component.html',
  styleUrls: ['./target-text.component.scss']
})
export class TargetTextComponent {
  @Input() TargetText : string = "";

  @Output() EventEmitterTEST : EventEmitter<string> = new EventEmitter<string>()
  EMIT(){
    console.warn("fuck");
    this.EventEmitterTEST.emit("FUCK!")
  }
}
