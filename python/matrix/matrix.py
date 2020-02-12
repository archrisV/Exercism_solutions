class Matrix:
    def __init__(self, matrix_string):
        self.rows = list(map(lambda x : list(map(lambda y: int(y), x.split(" "))) , matrix_string.split("\n")))
        self.columns = list(map(list, zip(*self.rows)))

    def row(self, index):
        return self.rows[index - 1]

    def column(self, index):
        return self.columns[index - 1]
