export const isPangram = (input) => {
  let lowercaseInput = input.toLowerCase();
  return [..."abcdefghijklmnopqrstuvxwyz"].every(x => lowercaseInput.includes(x));
};
