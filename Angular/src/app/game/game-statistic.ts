export class Stroke {
    constructor(public readonly expected: string,public readonly stroke : string, public readonly timestamp : Date = new Date()){
        let errorMessage : string = "";
        if(expected.length != 1) errorMessage += `Wrong constructor expected length, length is ${expected.length}.`;
        if(stroke.length != 1) errorMessage += `Wrong constructor stroke length, length is ${stroke.length}.`;
        if(errorMessage != "") throw new Error(errorMessage);
    }
    get Succes() : boolean{ return this.expected === this.stroke }

    /**
     * Provde a way to get the difference between to date in milisecond. Difference is always positiv.
     * @param firstStroke a Stroke object
     * @param secondStroke another Stroke object
     * @returns the time enlapsed between the two stroke is milisecond. Always positiv. 
     */
    public static DiffMiliSecond(firstStroke : Stroke,secondStroke : Stroke) : number{ 
        return Math.abs(secondStroke.timestamp.getTime() - firstStroke.timestamp.getTime())
    }
}

export class GameStatistic {
    strokes : Stroke[] = []
    push(stroke: Stroke){ this.strokes.push(stroke)}

    get TotalStroke() : number { return this.strokes.length }
    get TotalSuccesStroke() : number { return this.strokes.filter( el => el.Succes).length}
    get TotalErrorStroke() : number { return this.strokes.filter( el => !el.Succes).length}
    
}
