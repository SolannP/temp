import { Component,EventEmitter } from '@angular/core';
import { GameData, GameStatus } from '../interfaces/game-data';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  
  TargetText:string=`
AAAAA aaaaa AAAAA
AAAAA aaaaa AAAAA
AAAAA aaaaa AAAAA`;
/*
  TargetText:string=`
nom
ich du er sie es wir ihr sie sie
personal pronon akkusatif
mich dich`;*/

harderVersion:string=`
N__
I___D__E__S___E_W__Ihr Sie sie
Personal pronon akkusatif
Mich Dich`;
  CurrentText:string=""; //updated
  valueForGauge:number=100

  LogData(userInput:number){
    console.log(userInput)
  }

  // number of char per second
  intervalId? : any; /*NodeJS.Timeout*/
  intervalMillisecond:number = 2_000;
  interval:number = 0;

  allStrokeInfo?:GameData[];
  correctStrokeCountor:number=0;
  incorectStrokeCountor:number=0;

  // Speed data
  strokeSpeed:number = 0;
  strokeSpeedPercent: number =0;
  StrokeInfoToProceed:GameData[] = [];

  MAX_STROKE_SPEED = 200; //ms
  MIX_STROKE_SPEED = 2_000;

  DEBUG(result:string){
    console.warn(result)
  }
  AAAAA(data:GameData){
    this.StrokeInfoToProceed?.push(data);
    if(this.allStrokeInfo == undefined){
      //Init Stroke info
      this.allStrokeInfo = []

      // Proceed regular update
      this.intervalId = setInterval( () => { 
        console.log(`${this.strokeSpeed}ms/char | ${Math.round(this.strokeSpeed*0.001)}s/char`,this.strokeSpeedPercent)

        // if no data within the interval, count as minimal 
        if(this.StrokeInfoToProceed.length == 0) this.strokeSpeed = Math.round( (this.strokeSpeed+this.MIX_STROKE_SPEED)/2)
        else this.strokeSpeed = this.SpeedCalculation(this.StrokeInfoToProceed);
        this.strokeSpeedPercent = this.SpeedToPercent(this.strokeSpeed)

        //Reset Stroke to proceed
        this.StrokeInfoToProceed = []    

      },this.intervalMillisecond)
    }
    if(data.isSuccesStroke) this.correctStrokeCountor++;
    else this.incorectStrokeCountor++;
    this.allStrokeInfo?.push(data);
    

  }

  RunningGameStatus(status:GameStatus){
    if(status.isStarted) console.log("Start game")
    else if(status.isFinish) {
      console.debug("Stop game")
      clearInterval(this.intervalId)

      // Get proceed last speed data
      this.strokeSpeed = this.SpeedCalculation(this.StrokeInfoToProceed);
      //Reset Stroke to proceed
      this.StrokeInfoToProceed = []    

    }
    else if(status.isProgress) console.log("Progress")
    else console.error("unknow state")
  }

  private SpeedCalculation(values:GameData[]) : number {
    var sumOfInterval :number = 0;
    if(values.length == 0) return 0;
    values.reduce((prev, current) => {
      sumOfInterval += current.timestamp.getTime() - prev.timestamp.getTime();
      return current;
    });
    return Math.round(sumOfInterval / values.length);
  }

  
  private SpeedToPercent(value:number) : number{
    return Math.round(-0.05*value + 100)
  }

}


