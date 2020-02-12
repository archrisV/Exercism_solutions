class ArgumentError extends Error {}

class Wordy {
  constructor(input) {
    this._statement = input.replace(/(What\sis\s|by\s|of\s|\?)/g, "").split(' ');
    this._operands = this._statement.filter((x, i) => i % 2 == 0).map(x => Number(x));
    this._operators = this._statement.filter((x, i) => i % 2 == 1);
  }

  answer() {
    if(!this._operators.every(isValidOperation)){
      throw new ArgumentError();
    }
    return this._operators.reduce((total, operator) => {
      this._operands.unshift(operations.get(operator)
            (this._operands.shift(), this._operands.shift()));
      return this._operands[0];
    }, 0);
  }
}

const operations =  new Map([
  ['plus', (x, y) => x + y],
  ['minus', (x, y) => x - y],
  ['multiplied', (x, y) => x * y],
  ['divided', (x, y) => x / y],
  ['power', (x, y) => y ** x]
]);

const isValidOperation = x => [...operations.keys()].includes(x);

export { Wordy as WordProblem, ArgumentError };
