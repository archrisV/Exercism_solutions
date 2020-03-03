class Hamming {
    compute(firstStrand: string, secondStrand: string): number {
        if(firstStrand.length != secondStrand.length){
            throw new Error('DNA strands must be of equal length.');
        } 
        return [...firstStrand].filter((char, index) => char != secondStrand[index])
                                .length;
    }

}

export default Hamming