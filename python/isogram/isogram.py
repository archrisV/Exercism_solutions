def is_isogram(string):
    stringLower = string.lower().replace('-','').replace(' ', '')
    for x in stringLower:
        if stringLower.index(x) != stringLower.rindex(x):
            return False
    return True
