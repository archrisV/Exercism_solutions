export default class Pangram{
    private phrase: string;
    constructor(input: string){
        this.phrase = input.toLowerCase();
    }

    public isPangram(): boolean{
        return [...alphabet].every(x => this.phrase.includes(x));
    }    
}

const alphabet: string = "abcdefghijklmnopqrstuvxwyz";