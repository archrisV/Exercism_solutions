export class Allergies {
  constructor(allergiesMask) {
    this.allergiesMask = allergiesMask;
  }

  list() {
    return [...allergies.keys()].filter(allergy => this.allergicTo(allergy));
  }

  allergicTo(allergen) {
    return (allergies.get(allergen) & this.allergiesMask) === allergies.get(allergen);
  }
}

const allergies = new Map([
  [ 'eggs', 1 ],
  [ 'peanuts', 2 ],
  [ 'shellfish', 4 ],
  [ 'strawberries', 8 ],
  [ 'tomatoes', 16 ],
  [ 'chocolate', 32 ],
  [ 'pollen', 64 ],
  [ 'cats', 128 ]
]);