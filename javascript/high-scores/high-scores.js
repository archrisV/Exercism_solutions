export class HighScores {
  constructor(input) {
   this._scores = input;
  }

  get scores(){
    return this._scores;
  }

  get latest() {
    return Number(this._scores.slice(-1));
  }

  get personalBest() {
    return Math.max(...this._scores);
  }

  get personalTopThree() {
    let result = this._scores;
    return result.sort((x, y) => y - x).slice(0, 3);
  }
}
