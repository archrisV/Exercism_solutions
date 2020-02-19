export const matchingBrackets = (text) => {
  let stack = [];
  let keys = [...bracketPairs.keys()].join("");
  let vals = [...bracketPairs.values()].join("");
  for(let symbol of text){
    if (vals.includes(symbol)){
      stack.push(symbol);
    } else if (keys.includes(symbol)){
      let top = stack.pop();
      if(top === undefined || bracketPairs.get(symbol) !== top){
        return false;
      }
    }
  }
  return stack.length == 0;
};

const bracketPairs = new Map([
  ["]", "["],
  ["}", "{"],
  [")", "("]
]);