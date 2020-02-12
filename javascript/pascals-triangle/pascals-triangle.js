export class Triangle {
  constructor(size) {
    this._rows = this.calculateRows(size);
  }

  get lastRow() {
    return this._rows[this._rows.length - 1];
  }

  get rows() {
    return this._rows;
  }

  calculateRows(size){
    let rows = [];
    let value = 1;
    for(let i = 0; i < size; i++){
        let row = [];
        for(let j = 0; j <= i; j++){
          value = j == 0 || i == 0 ? 1 : value * ( i - j + 1 ) / j;
          row.push(value);
        }
        rows.push(row);
     }
     return rows;
  }
}
