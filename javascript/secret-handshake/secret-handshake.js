const answers = ['wink', 'double blink', 'close your eyes', 'jump']

export const secretHandshake = (number) => {
  if(!Number.isInteger(number)){
    throw new Error('Handshake must be a number');
  } 
  let result = [];
  for(let i = 0; i < answers.length; i++){
    if((number & Math.pow(2, i))){
      result.push(answers[i]);
    }
  }
  return (number & 16) ? result.reverse() : result;
};
