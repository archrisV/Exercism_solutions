export const isIsogram = (input) => {
  let word = input.replace(/\s|-/g, "").toLowerCase();
  return word.length === new Set(word).size;
};
