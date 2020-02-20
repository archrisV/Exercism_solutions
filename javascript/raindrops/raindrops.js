export const convert = (input) => {
  return [...pairs.keys()]
          .filter(key => input % key === 0)
          .map(key => pairs.get(key))
          .join('')
          || input.toString();
};

const pairs = new Map([
  [3, 'Pling'],
  [5, 'Plang'],
  [7, 'Plong']
]);