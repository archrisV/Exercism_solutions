export class Squares {
  constructor(num) {
    this.squareOfSum = Math.pow((num / 2) * (1 + num), 2);
    this.sumOfSquares = this.generateSumOfSquares(num);
    this.difference = Math.abs(this.sumOfSquares - this.squareOfSum);
  }

  generateSumOfSquares(n) {
    return (n < 2) ? 1 : n*n + this.generateSumOfSquares(--n);
  }
}
