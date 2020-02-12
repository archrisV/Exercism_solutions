translations = {
    'G' : 'C',
    'C' : 'G',
    'T' : 'A',
    'A' : 'U',
}

def to_rna(dna_strand):
    return "".join(map(lambda x: translations[x] , dna_strand))
