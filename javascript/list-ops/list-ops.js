export class List {
  constructor(list = []) {
    this.values = list;
  }

  append(list) {
    for(let value of list.values){
      this.values.push(value)
    }
    return this;
  }

  concat(lists) {
    for(let value of lists.values){
      this.append(value)
    }
    return this;
  }

  filter(fun) {
    let result = [];
    for(let value of this.values){
      if(fun(value)){
        result.push(value);
      }
    }
    return new List(result);
  }

  map(fun) {
    let result = [];
    for(let value of this.values){
      result.push(fun(value));
    }
    return new List(result);
  }

  length() {
    return this.values.length;
  }

  foldl(fun, acc) {
    for(let x of this.values){
      acc = fun(acc, x);
    }
    return acc;
  }

  foldr(fun, acc) {
    return this.reverse().foldl(fun, acc);
  }

  reverse() {
    return new List(this.values.reverse());
  }
}
