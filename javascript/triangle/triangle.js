export class Triangle {
  constructor(a, b, c) {
    this.a = a;
    this.b = b;
    this.c = c;
  }

  kind() {
    if(this.a <= 0 || this.b <= 0 || this.c <= 0) throw new Error("Size of a side is less than 0");
    else if (this.a + this.b < this.c || this.a + this.c < this.b || this.b + this.c < this.a) throw new Error("Not a triangle");
    else if (this.a == this.b && this.a == this.c) return "equilateral";
    else if (this.a != this.b && this.a != this.c && this.b != this.c) return "scalene";
    else return "isosceles";
  }
}
