def distance(strand_a, strand_b):
    if(len(strand_a) != len(strand_b)):
        raise ValueError("Stands are not equal.")
    return len([ x for x, y in list(zip(strand_a, strand_b)) if x != y])
