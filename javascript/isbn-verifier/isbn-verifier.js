export class ISBN {
  constructor(isbn) {
    this.isbn = isbn.replace(/-/g, "");
  }
  isValid() {
    return  this.isLexicallyValid() && this.isNumericallyValid();
  }
  isLexicallyValid(){
    return new RegExp(/^[0-9]{9}([0-9]|X)$/).test(this.isbn);
  }
  isNumericallyValid(){
    return [...this.isbn]
      .map((x, i) => x === "X" ? 10 * (this.isbn.length - i) : Number(x) * (this.isbn.length - i))
      .reduce((x, y) => x + y) % 11 === 0;
  }
}
