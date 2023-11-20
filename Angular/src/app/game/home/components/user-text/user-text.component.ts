import { Time } from '@angular/common';
import { Component, DoCheck, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { GameData, GameStatus } from 'src/app/game/interfaces/game-data';

@Component({
  selector: 'app-user-text',
  templateUrl: './user-text.component.html',
  styleUrls: ['./user-text.component.scss']
})

export class UserTextComponent implements OnChanges {

  @Output() GameDataEvent : EventEmitter<GameData> = new EventEmitter<GameData>();
  @Output() RunningGameStatusEvent : EventEmitter<GameStatus> = new EventEmitter<GameStatus>();
  @Input() ExpectedInput:string="";

  exptecedInputByChar:string[] = [];
  GameStatus : GameStatus= new GameStatus();

  ngOnChanges(changes: SimpleChanges): void {
    this.exptecedInputByChar = this.ExpectedInput.split('');
    document.getElementById(`text-input-id-${0}`)?.focus();
  }

  ProceedInput(expectedCurrentChar:string,currentIndex : number,refUserInputElementc: any,isFirst:boolean = false,isLast:boolean=false){
    const isSuccesStroke:boolean = (expectedCurrentChar == refUserInputElementc.value)
    if(isFirst) this.StartTimer();
    if(isSuccesStroke){
      document.getElementById(`text-input-id-${currentIndex+1}`)?.focus();
      if(isLast) this.StopTimer();
    }
    else{
      refUserInputElementc.value = "";
    }
    const StrokeData:GameData= {
      isSuccesStroke: isSuccesStroke,
      timestamp: new Date()
    }
    this.GameDataEvent.emit(StrokeData)
  }

  StartTimer() {
    this.GameStatus.Start = new Date();
    
    this.RunningGameStatusEvent.emit(this.GameStatus)
  }

  StopTimer() {
    this.GameStatus.End = new Date();
    this.RunningGameStatusEvent.emit(this.GameStatus)
  }
}

