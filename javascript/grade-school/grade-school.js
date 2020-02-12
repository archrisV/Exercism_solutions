export class GradeSchool {
  constructor() {
    this._roster = {};
  }

  add(name, grade) {
    if (this._roster[grade] === undefined){
      this._roster[grade] = [];
    } 
    this._roster[grade].push(name);
    this._roster[grade].sort();
  }

  roster() {
    return JSON.parse(JSON.stringify(this._roster));
  }

  grade(grade) {
    return this._roster[grade] ? this._roster[grade].concat() : [];
  }
}
