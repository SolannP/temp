import { Component, Input, OnInit } from '@angular/core';
import { NgClass } from '@angular/common'

@Component({
  selector: 'app-game',
  standalone: true,
  imports: [NgClass],
  templateUrl: './game.component.html',
  styleUrl: './game.component.scss'
})
export class GameComponent implements OnInit{
  @Input({ 
    required:true,
    alias:"txt",
    transform: (val:string) => new GameFacade(val) })
  targetText? : GameFacade;

  currendIndexWord: number = 0;
  currentIndexChar : number = 0;
  currentWordTarget: string = "";

  currentWordInput : string = "";
  
  get gWords() {
    return this.targetText?.gWords
  }

  constructor(){
    
  }
  ngOnInit(): void {
    console.log(this.targetText)
    this.currentWordTarget = this.gWords?.at(0)?.ToString() ?? "";
  }


  GetWordClass(currendIndexWord:number,indexWord:number): string[]{
    let result : string[] = ['word'];
    if(currendIndexWord > indexWord) result.push('previous')
    else if(currendIndexWord == indexWord) result.push('current')
    else result.push('comming')
    return result;
  }

  IsCurrent(currendIndexWord: number,indexWord: number): boolean { return currendIndexWord == indexWord; }
  IsPrevious(currendIndexWord: number,indexWord: number) :boolean{ return currendIndexWord > indexWord;}

  Refresh() {
    let currentWord = this.targetText?.gWords[this.currendIndexWord];
    if(currentWord == undefined) return;
    Array.from(this.currentWordInput).forEach( (element,index) => {
      if(currentWord?.gChars[index] === undefined) return
    });

  }
    
}

class gChar {
  constructor(private readonly target:string, private readonly index : { indexWord:number,indexChar:number,indexAbsolute: number}){}
  private current? : string;
  private first:boolean = false;
  private timestamp? : Date;

  get Target(): string { return this.target }
  get IndexWord(): number { return this.index.indexWord }
  get IndexChar(): number { return this.index.indexChar }
  get IndexAbsolute(): number { return this.index.indexAbsolute }
  get Current() : string | undefined{ return this.current ;}
  set Current(current : string) {
    if(this.current == undefined){
      this.first = true;
      this.current = current
      this.timestamp = new Date();
    }
  }
  get Succes() : boolean { return this.target === this.current ?? false}
  get FirstStroke(): boolean { return this.first}
  get Timestamp(): Date | undefined { return this.timestamp }
}

class gWord {
  public readonly gChars: gChar[] = [];
  ToString() : string { return this.gChars.reduce<string>( (prev,current) => prev.concat(current.Target), "") }
  /**
   * 
   * @param input word or a space to proceed
   * @param indexWord index of the word into the text. Starting from 0 to text.lenght_word -1
   * @param indexAbsoluteFirstChar index of the first char of this word regarding the entire text. Used for compute the absolute index of this char regarding the text. Starting from 0 to the text.lenght-1
   */
  constructor(input: string,indexWord : number,indexAbsoluteFirstChar : number,absoluteIndexAccessor:AbosluteIndex ){
    let array = input.split("")
    if(array.length == 0) throw Error(`Word cannot be of compose of 0 letters, please check what word and how it's proceed, current is: ${input}`)
    array.forEach( (element,indexChar) => {
      let char = new gChar(
        element,{
          indexWord: indexWord,
          indexChar:indexChar,
          indexAbsolute:indexAbsoluteFirstChar+indexChar
        });
      this.gChars.push(char)
      absoluteIndexAccessor[indexAbsoluteFirstChar+indexChar] = char
    });
  }

  get IndexWord() : number{ return this.gChars.at(0)!.IndexWord } // Safe because check when construct
  get IsSpace(): boolean { return this.gChars.at(0)!.Target === " " } // Safe because check when construct
  get IsWord(): boolean { return !this.IsSpace }
}


class GameFacade {
  public readonly gWords: gWord[] = [];
  public readonly first :number= 0;
  public readonly last : number;
  public absoluteIndexAccessor : AbosluteIndex = {};
  constructor(input: string){
    let array = input.replaceAll(" ","_ _").split("_");
    let absolutIndexFirstChar = 0;
    array.forEach( (element,indexWord) => {
      this.gWords.push(new gWord(element,indexWord,absolutIndexFirstChar,this.absoluteIndexAccessor))
      absolutIndexFirstChar = absolutIndexFirstChar + (element.length)
    });
    this.last = absolutIndexFirstChar - 1
  }

}

interface AbosluteIndex {
  [index :number]: gChar
}
