export default class RobotName { 
    public _name: string;
    constructor(){
        this._name = generateName();
    }
    resetName(){
        this._name = generateName();
    }
    get name(){
        return this._name;
    }

}

let names: string[] = [];
const alphabet:string = "ABCDEFGIJKLMNOPQRSTUVYWZX"; 

const generateName = ():string => {
    let tmpName;
    do{
        tmpName = `${getRandomLetters()}${getRandomNumber()}`;
    }while(names.includes(tmpName));
    names.push(tmpName);
    return tmpName;
};

const getRandomNumber = ():string => String(getRandom(1000)).padStart(3, '0'); 

const getRandomLetters = ():string => `${alphabet[getRandom(alphabet.length)]}${alphabet[getRandom(alphabet.length)]}`; 

const getRandom = (max: number):number => Math.floor(Math.random() * max); 
