export default class HandShake{
    private readonly commandMask: number;
    constructor(input: number){
        if(!Number.isInteger(input)){
            throw new Error('Handshake must be a number');
        } 
        this.commandMask = input;
    }
    commands(): string[]{
        let result = [];
        for(let i = 0; i < answers.length; i++){
            if((this.commandMask & Math.pow(2, i))){
              result.push(answers[i]);
            }
        }
        return (this.commandMask & 16) ? result.reverse() : result;
    }
}

const answers: string[] = ['wink', 'double blink', 'close your eyes', 'jump'];