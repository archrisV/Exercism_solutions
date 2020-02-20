export const square = (input) => {
  if(input < 1 || input > 64){
    throw new Error('square must be between 1 and 64');
  }
  return 1n << (BigInt(input) - 1n);
};

export const total = () => (1n << 64n) - 1n;
