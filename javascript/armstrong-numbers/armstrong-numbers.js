export const isArmstrongNumber = (num) => {
  let numStr = num.toString();
  return [...numStr]
            .map(x => Math.pow(Number(x), numStr.length))
            .reduce((x, y) => x + y, 0) 
            === num;
};
