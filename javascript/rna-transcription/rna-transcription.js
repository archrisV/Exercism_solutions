export const toRna = (dna) => [...dna].map(x => translations[x]).join("");

const translations = {
  'G' : 'C',
  'C' : 'G',
  'T' : 'A',
  'A' : 'U'
}
