export class Robot { 
    constructor(){
        this._name = generateName();
    }
    reset(){
        this._name = generateName();
    }
    get name(){
        return this._name;
    }

}

let names = [];
const alphabet = "ABCDEFGIJKLMNOPQRSTUVYWZX"; 

Robot.releaseNames = () => names = []; 

const generateName = () => {
    let tmpName;
    do{
        tmpName = `${getRandomLetters()}${getRandomNumber()}`;
    }while(names.includes(tmpName));
    names.push(tmpName);
    return tmpName;
};

const getRandomNumber = () => String(getRandom(1000)).padStart(3, '0'); 

const getRandomLetters = () => `${alphabet[getRandom(alphabet.length)]}${alphabet[getRandom(alphabet.length)]}`; 

const getRandom = (max) => Math.floor(Math.random() * max); 
