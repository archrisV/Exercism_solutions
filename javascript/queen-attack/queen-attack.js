export class QueenAttack {
    constructor(queens = { white: [0, 3], black: [7, 3] }) {
        if((queens.white).every((value, index) => value == queens.black[index])){
            throw new Error('Queens cannot share the same space');
        } else if (this.max(queens.white) > 7 || this.max(queens.black) > 7 
                || this.min(queens.white) < 0 || this.min(queens.black) < 0){
                    throw new Error('Queens out of bounds');
        }
        this.white = queens.white;
        this.black = queens.black;
    }

    toString() {
        let result = [];
        for(let i = 0; i < 8; i++){
            for(let j = 0; j < 8; j++){
                if(i == this.white[0] && j == this.white[1]){
                    result.push(this.pad("W", j));
                }else if(i == this.black[0] && j == this.black[1]){
                    result.push(this.pad("B", j));
                }else{
                    result.push(this.pad("_", j));
                }
            }
            result.push("\n");
        }
        return result.join("");
    }

    canAttack() {
            return this.black[0] == this.white[0] || this.black[1] == this.white[1] 
            ? true : Math.abs(this.white[0] - this.black[0]) == Math.abs(this.white[1] - this.black[1]) 
            ? true : false;
    }
    
    max(arr){ return Math.max(...arr); }
    min(arr){ return Math.min(...arr); }
    pad(symbol, iter){ return iter == 7 ? symbol : `${symbol} `; }
}
