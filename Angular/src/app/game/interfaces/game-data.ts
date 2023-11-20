export interface GameData {
    isSuccesStroke:boolean
    timestamp:Date
  }

export class GameStatus {
    constructor(start?:Date){ this.start = start}
    public set Start(start:Date){
      this.start = start
    }
    public set End(end:Date){
      this.end = end
    }
    public get isStarted():boolean {
      return this.start != undefined
    }
    public get isFinish():boolean {
      return this.end != undefined
    }
    public get isProgress():boolean {
      return this.start != undefined && this.end == undefined
    }
    private start?:Date;
    private end?:Date;
  }  