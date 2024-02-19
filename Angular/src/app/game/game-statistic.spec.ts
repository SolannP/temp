import { GameStatistic, Stroke } from './game-statistic';

describe('GameStatistic', () => {
  it('should create an instance', () => {
    expect(new GameStatistic()).toBeTruthy();
  });
});

describe('Stroke', () => {
  it('correct create an instance', () => {
    expect(new Stroke('a','a')).toBeTruthy();
  })
  it('incorrect create an instance', () => {
    expect(function() { new Stroke('a','aa')}).toThrow()
    expect(function() { new Stroke('a','bb')}).toThrow()
    expect(function() { new Stroke('aa','bb')}).toThrow()
  })
  it('correct value of the instance', () => {
    //arrange 
    let FirstCorrectStroke = new Stroke('a','a',new Date(2024,1,2,20,30,40,50)); // 2024/01/02 20h30 40s 50ms
    let SecondCorrectStroke = new Stroke('b','B',new Date(2024,1,2,20,30,40,60)); // 2024/01/02 20h30 40s 60ms

    //act
    let msDiff = Stroke.DiffMiliSecond(FirstCorrectStroke,SecondCorrectStroke)
    let isCorrectFirstStroke = FirstCorrectStroke.Succes
    let isIncorrectSecondStroke = SecondCorrectStroke.Succes

    //assert
    expect(isCorrectFirstStroke).toBeTrue()
    expect(isIncorrectSecondStroke).toBeFalse()
    expect(msDiff).toBe(10)
  });
});