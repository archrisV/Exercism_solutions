def square(number):
    if(number < 1 or number > 64):
        raise ValueError("Number out of bounds")
    return 1 << (number - 1)

total = (lambda : (1 << 64) - 1)
