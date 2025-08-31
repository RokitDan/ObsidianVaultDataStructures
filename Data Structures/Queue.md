https://youtu.be/r51TRDECIw4?t=668
https://youtu.be/O9v10jQkm5c?t=508

A queue is a linear data structure that follows the First In, First Out (FIFO) principle. The first element added to the queue will be the first one to be removed.

**Key operations:**
- Enqueue: Add an element to the rear/tail of the queue
- Dequeue: Remove and return the front/first element
- Front/Peek: View the first element without removing it
- Rear: View the last element
- isEmpty: Check if the queue is empty
- Size: Get the number of elements

**Queues are commonly used for:**
- Task scheduling in operating systems
- Breadth-first search in graphs
- Handling requests in web servers
- Buffering data in streams
- Print queue management
- Music app playlists

**Time Complexity**
- Accessing a specific element in the queue is [[O(n) - Linear time]]
- Inserting/deletion is [[O(1) - Constant time]] 
	- Items can only be removed from the front and added to the back

**JavaScript array implementation:**

```javascript
class Queue {
  constructor() {
    this.items = [];
  }

  // Add element to rear
  enqueue(element) {
    this.items.push(element);
  }

  // Remove element from front
  dequeue() {
    if (this.isEmpty()) return null;
    return this.items.shift();
  }

  // View front element
  front() {
    if (this.isEmpty()) return null;
    return this.items[0];
  }

  // View rear element
  rear() {
    if (this.isEmpty()) return null;
    return this.items[this.items.length - 1];
  }

  // Check if empty
  isEmpty() {
    return this.items.length === 0;
  }

  // Get size
  size() {
    return this.items.length;
  }

  // Display queue contents
  display() {
    console.log(this.items);
  }
}

// Example usage:
const queue = new Queue();
queue.enqueue(10);
queue.enqueue(20);
queue.enqueue(30);
console.log(queue.front()); // 10
console.log(queue.dequeue()); // 10
console.log(queue.size()); // 2
```

In C#, the Queue class is available in the System.Collections.Generic namespace:
```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a queue
        Queue<int> queue = new Queue<int>();

        // Enqueue elements (add to rear)
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // View front element
        Console.WriteLine($"Front element: {queue.Peek()}"); // 10

        // Dequeue elements (remove from front)
        Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // 10
        Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // 20

        // Check if queue is empty
        Console.WriteLine($"Is empty: {queue.Count == 0}"); // False

        // Get queue size
        Console.WriteLine($"Queue size: {queue.Count}"); // 1

        // Dequeue remaining element
        Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // 30
        Console.WriteLine($"Is empty: {queue.Count == 0}"); // True
    }
}
```

**C# Queue operations:**
- Enqueue(item): Add item to rear
- Dequeue(): Remove and return first item
- Peek(): View first item without removing
- Count: Get number of elements
- IsEmpty(): Check if empty (check Count == 0)

The queue follows FIFO (First In, First Out) principle where the first element added is the first one to be removed.

The FIFO principle makes queues ideal for scenarios where order preservation is important, such as managing tasks in the order they arrive or processing elements
in sequence.