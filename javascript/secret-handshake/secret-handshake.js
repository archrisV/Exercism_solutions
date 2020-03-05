const answers = ['wink', 'double blink', 'close your eyes', 'jump']

export const secretHandshake = (number) => {
  if(!Number.isInteger(number)){
    throw new Error('Handshake must be a number');
  } 
  let result = answers.filter((x, i) => number & Math.pow(2, i));
  return (number & 16) ? result.reverse() : result;
};
