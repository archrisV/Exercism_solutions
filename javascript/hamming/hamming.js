export const compute = (strand1, strand2) => {
  if(strand1 === '' && strand2.length !== 0){
    throw new Error('left strand must not be empty');
  }
  if(strand2 === '' && strand1.length !== 0){
    throw new Error('right strand must not be empty');
  }
  if(strand1.length !== strand2.length){
    throw new Error('left and right strands must be of equal length');
  }
  return [...strand1].filter((x, i) => x !== strand2[i]).length;
};
