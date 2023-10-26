import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  TargetText:string="Ich Du Er Sie Es Wir Ihr Sie sie";
  CurrentText:string=""; //updated

  constructor(){
    
  }
  LogData(userInput:number){
    console.log(userInput)
  }
}

