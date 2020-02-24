export class NucleotideCounts {
  static parse(dnaStrand) {
    if([...dnaStrand].filter(x => !"ACGT".includes(x)).length !== 0){
      throw new Error('Invalid nucleotide in strand');
    }
    return `${nucleotideCount(dnaStrand, 'A')} ${nucleotideCount(dnaStrand, 'C')} ${nucleotideCount(dnaStrand, 'G')} ${nucleotideCount(dnaStrand, 'T')}`;
  }
}

const nucleotideCount = (strand, nucleotide) => [...strand].filter(x => nucleotide === x).length;