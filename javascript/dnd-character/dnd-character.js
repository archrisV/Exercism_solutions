export const abilityModifier = (score) => {
  if(score > 18){
    throw new Error('Ability scores can be at most 18');
  }else if(score < 3){
    throw new Error('Ability scores must be at least 3');
  }
  return Math.floor((score - 10) / 2);
};

export class Character {
  //rolls dice 4 times, returns sum of 3 highest rolls
  static rollAbility() {
    let rolls = [];
    for(let i = 0; i < 4; i++){
      rolls.push(rollDice(1, 6));
    }
    return rolls.sort().slice(1).reduce((x, y) => x + y, 0);
  }
  
  constructor(){
    this.strength = Character.rollAbility();
    this.dexterity = Character.rollAbility();
    this.constitution = Character.rollAbility();
    this.intelligence = Character.rollAbility();
    this.wisdom = Character.rollAbility();
    this.charisma = Character.rollAbility();
    this.hitpoints = 10 + abilityModifier(this.constitution);
  }
}

const rollDice = (min, max) => {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}