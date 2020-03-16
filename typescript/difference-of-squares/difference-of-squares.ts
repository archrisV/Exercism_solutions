export default class Squares{
    public readonly squareOfSum: number;
    public readonly sumOfSquares: number;
    public readonly difference: number;

    constructor(num: number){
        this.squareOfSum = Math.pow((num / 2) * (1 + num), 2);
        this.sumOfSquares = this.generateSumOfSquares(num);
        this.difference = Math.abs(this.sumOfSquares - this.squareOfSum);
    }
          
    private generateSumOfSquares(n: number): number {
        return (n < 2) ? 1 : n*n + this.generateSumOfSquares(--n);
    }
}