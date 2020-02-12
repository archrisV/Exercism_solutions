export const translate = (input) => {
  if(!input) return [];
  let result = [];
  for(let i = 0; i < input.length; i += 3)
  {
    let protein = input.substr(i, 3);
    if(!proteins[protein]) throw Error("Invalid codon");
    else if(proteins[protein] === "STOP") break;
    result.push(proteins[protein]);
  }
  return result;
};

const proteins = {
  "AUG" : "Methionine",
  "UUU" : "Phenylalanine", "UUC" : "Phenylalanine",
  "UUA" : "Leucine", "UUG" : "Leucine" ,
  "UCU" : "Serine", "UCC" : "Serine" , "UCA" : "Serine" , "UCG" : "Serine" ,
  "UAU" : "Tyrosine", "UAC" : "Tyrosine",
  "UGU" : "Cysteine", "UGC" : "Cysteine",
  "UGG" : "Tryptophan",
  "UAA" : "STOP",
  "UAG" : "STOP",
  "UGA" : "STOP"
};

