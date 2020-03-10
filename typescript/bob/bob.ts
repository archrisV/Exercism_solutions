export default class Bob {
    public hey(statement: string) {
        let phrase = statement.trim();
        if (phrase.length == 0){
            return "Fine. Be that way!";
        } 
        if (this.isYell(phrase) && this.isQuestion(phrase) && this.hasLetters(phrase)){
            return "Calm down, I know what I'm doing!";
        }
        if (this.isYell(phrase) && this.hasLetters(phrase)){
            return "Whoa, chill out!";
        } 
        if (this.isQuestion(phrase)){
            return "Sure.";
        } 
        return "Whatever.";
    }

    private isYell(input: string): boolean{
        return [...input].every(x => x === x.toUpperCase());
    }

    private hasLetters(input: string){
        return input.match(/[a-zA-Z]/);
    } 

    private isQuestion(input: string): boolean{
        return input.endsWith("?");
    } 
}

