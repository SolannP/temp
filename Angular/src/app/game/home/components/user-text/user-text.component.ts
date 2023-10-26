import { Component, DoCheck, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-user-text',
  templateUrl: './user-text.component.html',
  styleUrls: ['./user-text.component.scss']
})
export class UserTextComponent implements OnChanges {

  @Output() EventUserTypeText = new EventEmitter<number>();
  @Input() ExpectedInput:string="";
  AllInput:string[] = [];
  UserInput:string =""
  currentNumber:number = 0;

  constructor(){
    
  }
  ngOnChanges(changes: SimpleChanges): void {
    this.AllInput = this.ExpectedInput.split('');
  }

  ProceedInput(c:string,i:number,ref:any){
    if(c == ref.value){
      document.getElementById(`text-input-id-${i+1}`)?.focus();
    }
    else{
      ref.value = "";
    }
  }
}


