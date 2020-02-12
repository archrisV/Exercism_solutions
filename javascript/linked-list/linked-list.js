export class LinkedList {
  constructor(){
    this.setHeadAndTail();
  }

  push(val) {
    let node = new Node(val);
    if(!this.head){
      this.setHeadAndTail(node);
    } else {
      node.prev = this.tail;
      this.tail.next = node;
      this.tail = node;
    }
  }

  pop() {
    let value = this.tail.value;
    if(this.head == this.tail){
      this.setHeadAndTail(null);
    }else{
      this.tail = this.tail.prev;
    }
    return value;
  }

  shift() {
    let value = this.head.value;
    this.head = this.head.next;
    return value;
  }

  unshift(val) {
    let node = new Node(val);
    if(!this.head){
      this.setHeadAndTail(node);
    }else {
      node.next = this.head;
      this.head.prev = node;
      this.head = node;
    }

  }

  delete(val) {
    let current = this.head;
    while(current){
      if(current.value === val){
        if(current == this.head && current == this.tail){
          this.setHeadAndTail();
        }else if(current == this.head){
          this.head = this.head.next;
          this.head.prev = null;
        }else if(current == this.tail){
          this.tail = this.tail.prev;
          this.tail.next = null;
        }else{
          current.prev.next = current.next;
          current.next.prev = current.prev;
        }
        break;
      }
      current = current.next;
    }
  }

  count() {
    let counter = 0;
    let current = this.head;
    while(current){
      counter++;
      current = current.next;
    }
    return counter;
  }
  setHeadAndTail(val = null){
    this.head = val;
    this.tail = val;
  }
}

class Node{
  constructor(val){
    this.value = val;
    this.next = null;
    this.prev = null;
  }
}