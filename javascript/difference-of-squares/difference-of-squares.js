export class Squares {
  constructor(num) {
    this.squareOfSum = Math.pow((num / 2) * (1 + num), 2);
    this.sumOfSquares = this.generateSumOfSquares(num);
    this.difference = Math.abs(this.sumOfSquares - this.squareOfSum);
  }

  generateSumOfSquares(n) {
    if(n <= 1){
      return 1;
    }
    return n*n + this.generateSumOfSquares(--n);
  }

}
