https://youtu.be/r51TRDECIw4?t=222
https://youtu.be/O9v10jQkm5c?t=352

A linked list is a linear data structure where elements are stored in nodes that point to the next node in the sequence. Unlike arrays, linked lists don't store
elements in contiguous memory locations.

**Key characteristics:**

- Each node contains data and a reference (pointer) to the next node
- Dynamic size - can grow or shrink at runtime
- No random access - must traverse from the beginning to reach a specific element
- Additional memory overhead for storing pointers/references

**Time Complexity**:

- Efficient insertion/deletion at any position ([[O(1) - Constant time]] if you have reference to node)
- Without reference to node, insertion/deletion is [[O(n) - Linear time]]


**Types:**

1. Singly linked list - each node points to the next node
2. Doubly linked list - each node points to both next and previous nodes
3. Circular linked list - last node points back to the first node

**JavaScript implementation of a singly linked list:**

```javascript
class ListNode {
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}

class LinkedList {
  constructor() {
    this.head = null;
    this.size = 0;
  }

  // Add element at the beginning
  prepend(data) {
    const newNode = new ListNode(data);
    newNode.next = this.head;
    this.head = newNode;
    this.size++;
  }

  // Add element at the end
  append(data) {
    const newNode = new ListNode(data);
    if (!this.head) {
      this.head = newNode;
    } else {
      let current = this.head;
      while (current.next) {
        current = current.next;
      }
      current.next = newNode;
    }
    this.size++;
  }

  // Get element at index
  get(index) {
    if (index < 0 || index >= this.size) return null;

    let current = this.head;
    for (let i = 0; i < index; i++) {
      current = current.next;
    }
    return current.data;
  }

  // Remove element by value
  remove(data) {
    if (!this.head) return false;

    // If head contains the data
    if (this.head.data === data) {
      this.head = this.head.next;
      this.size--;
      return true;
    }

    let current = this.head;
    while (current.next && current.next.data !== data) {
      current = current.next;
    }

    if (current.next) {
      current.next = current.next.next;
      this.size--;
      return true;
    }

    return false;
  }
}
```

Linked lists are advantageous when frequent insertions/deletions are needed, but an [[Array]] is better for random access and memory locality.