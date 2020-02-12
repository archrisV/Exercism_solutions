export class Matrix {
  constructor(input) {
    this._rows = input.split("\n").map(x => x.split(" ").map( y => Number(y)));
    this._columns = this._rows[0].map((col, i) => this._rows.map(row => row[i]));
  }
  get rows(){
    return this._rows;
  }
  get columns() {
    return this._columns;
  }
}
