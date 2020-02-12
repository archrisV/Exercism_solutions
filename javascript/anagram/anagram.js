export class Anagram {
  constructor(word) {
    this._word = word.toLowerCase();
    this._sortedWord = [...(word.toLowerCase())].sort().join("");
  }

  matches(list) {
    return list.filter(x => x.toLowerCase() != this._word && [...(x.toLowerCase())].sort().join("") == this._sortedWord);
  }
}
