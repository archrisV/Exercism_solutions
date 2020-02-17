class Transcriptor {
    public toRna( dna : string ): string {
        let rna = "";
        [...dna].forEach(letter => {
            if (this.translations[letter] === undefined) {
                throw new Error("Invalid input DNA.");
            }
            rna += this.translations[letter];
        })
        return rna;
    }

    private translations: { [key: string]: string } = {
        "G": "C",
        "C": "G",
        "T": "A",
        "A": "U"
      }
}

export default Transcriptor