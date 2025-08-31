https://youtu.be/O9v10jQkm5c?t=570

A heap is a specialized tree-based data structure that satisfies the heap property. In a max heap, for every parent node, the value is greater than or equal to its
children. In a min heap, the value is less than or equal to its children.

---

#### Min Heap
Every parent is smaller than its children
```
        1
       / \
      3   6
     / \ / \
    5 10 8 12
```

This is a min heap with integer values where:

• Root node contains 1 (minimum value)
• Each parent node is smaller than or equal to its children
• The tree is complete (all levels filled except possibly last, which fills left to right)

In array representation: [1, 3, 6, 5, 10, 8, 12]

For a node at index i:

• Parent is at index (i-1)/2
• Left child is at index 2*i+1
• Right child is at index 2*i+2

So for index 3 (value 5):

• Parent is at index 1 (value 3)
• Left child is at index 7 (doesn't exist)
• Right child is at index 8 (doesn't exist)

The heap property ensures the smallest element is always at the root, making it efficient for priority queue operations.

---

#### Max Heap
- Every parent is larger than its children
```
       15
       / \
      10  8
     / \ / \
    3  5 6  2
```

This is a max heap with integer values where:

• Root node contains 15 (maximum value)
• Each parent node is greater than or equal to its children
• The tree is complete (all levels filled except possibly last, which fills left to right)

In array representation: [15, 10, 8, 3, 5, 6, 2]

For a node at index i:

• Parent is at index (i-1)/2
• Left child is at index 2*i+1
• Right child is at index 2*i+2

So for index 1 (value 10):

• Parent is at index 0 (value 15)
• Left child is at index 3 (value 3)
• Right child is at index 4 (value 5)

The heap property ensures the largest element is always at the root, making it efficient for priority queue operations where highest priority elements should be
processed first.

**Key characteristics:**

• Complete binary tree (all levels filled except possibly last, which fills left to right)
• Can be efficiently implemented using arrays
• Parent at index i has children at indices 2i+1 and 2i+2
• Parent of node at index i is at index (i-1)/2
• Operations: Insert, Extract (remove root), Peek

Priority Queue is an abstract data type that implements a heap, where elements are processed based on their priority (highest priority first).

**Operations:**

• Insert/Enqueue: Add element with priority
• Extract/Dequeue: Remove element with highest priority
• Peek: View highest priority element
• Heapify: Maintain heap property

JavaScript implementation:

```javascript
class MaxHeap {
  constructor() {
    this.heap = [];
  }

  // Get parent index
  parentIndex(index) {
    return Math.floor((index - 1) / 2);
  }

  // Get left child index
  leftChildIndex(index) {
    return 2 * index + 1;
  }

  // Get right child index
  rightChildIndex(index) {
    return 2 * index + 2;
  }

  // Swap elements
  swap(index1, index2) {
    [this.heap[index1], this.heap[index2]] = [this.heap[index2], this.heap[index1]];
  }

  // Insert element
  insert(value) {
    this.heap.push(value);
    this.bubbleUp(this.heap.length - 1);
  }

  // Move element up to maintain heap property
  bubbleUp(index) {
    if (index === 0) return;

    const parentIndex = this.parentIndex(index);
    if (this.heap[parentIndex] < this.heap[index]) {
      this.swap(parentIndex, index);
      this.bubbleUp(parentIndex);
    }
  }

  // Extract maximum element
  extractMax() {
    if (this.heap.length === 0) return null;

    const max = this.heap[0];
    const last = this.heap.pop();

    if (this.heap.length > 0) {
      this.heap[0] = last;
      this.bubbleDown(0);
    }

    return max;
  }

  // Move element down to maintain heap property
  bubbleDown(index) {
    const leftChild = this.leftChildIndex(index);
    const rightChild = this.rightChildIndex(index);
    let maxIndex = index;

    if (leftChild < this.heap.length &&
        this.heap[leftChild] > this.heap[maxIndex]) {
      maxIndex = leftChild;
    }

    if (rightChild < this.heap.length &&
        this.heap[rightChild] > this.heap[maxIndex]) {
      maxIndex = rightChild;
    }

    if (maxIndex !== index) {
      this.swap(index, maxIndex);
      this.bubbleDown(maxIndex);
    }
  }

  // Get maximum element
  peek() {
    return this.heap.length > 0 ? this.heap[0] : null;
  }

  // Check if empty
  isEmpty() {
    return this.heap.length === 0;
  }
}

// Example usage:
const heap = new MaxHeap();
heap.insert(10);
heap.insert(20);
heap.insert(15);
heap.insert(30);
console.log(heap.peek()); // 30
console.log(heap.extractMax()); // 30
```

In C#, there isn't a built-in priority queue in the standard library, but you can use the PriorityQueue<TElement, TPriority> class available in .NET 6 and later:

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a priority queue with elements and their priorities
        var priorityQueue = new PriorityQueue<string, int>();

        // Enqueue elements with priorities (lower number = higher priority)
        priorityQueue.Enqueue("Task 1", 3); // Priority 3 (lowest)
        priorityQueue.Enqueue("Task 2", 1); // Priority 1 (highest)
        priorityQueue.Enqueue("Task 3", 2); // Priority 2

        // Dequeue elements by priority (highest priority first)
        Console.WriteLine($"Next task: {priorityQueue.Dequeue()}");
        // Output: Task 2 (priority 1)

        Console.WriteLine($"Next task: {priorityQueue.Dequeue()}");
        // Output: Task 3 (priority 2)

        Console.WriteLine($"Next task: {priorityQueue.Dequeue()}");
        // Output: Task 1 (priority 3)

        // For a heap-like implementation using SortedList:
        var heap = new SortedList<int, string>();
        heap.Add(10, "Item 1");
        heap.Add(5, "Item 2");
        heap.Add(15, "Item 3");

        // Extract minimum (first element in sorted order)
        var minKey = heap.Keys[0];
        Console.WriteLine($"Minimum: {heap[minKey]}"); // Item 2 (priority 5)
    }
}
```

For earlier .NET versions, you'd need to implement your own priority queue using a heap structure or use third-party libraries.

The priority queue follows the principle that elements with lower priority values are processed first ([[#Min Heap]] behavior), making it perfect for scheduling tasks, event processing, and [[Graph]] algorithms like [[Dijkstra's]] shortest path.

--- 
### Binary Heap

A binary heap is a complete binary tree-based data structure that satisfies the heap property. It's commonly used to implement priority [[Queue]]s.

Key characteristics:

• Complete binary [[Tree]] (all levels filled except possibly the last, which fills left to right)
• Two types:
	• [[#Max Heap]]: Parent >= both children
	• [[#Min Heap]] Parent <= both children
• Stored in an array for efficiency
• Operations:
	• Insert: [[O(log n) - Logarithmic time]]
	• Extract min/max: [[O(log n) - Logarithmic time]]
	• Peek: [[O(1) - Constant time]] 


In [[Dijkstra's]] algorithm, a binary heap is used as a priority [[Queue]] to efficiently select the vertex with the minimum distance at each step, improving [[Time Complexity]] from O(V²) to O((V + E) log V).

In the context of binary heap time complexity, V represents the number of elements (vertices) in the heap.

**For example:**

• In Dijkstra's algorithm with binary heap: O((V + E) log V)
	• V = number of vertices
	• E = number of edges
• Insertion into heap: O(log V)
• Extraction from heap: O(log V)

The V subscript indicates that the time complexity grows logarithmically with respect to the number of elements in the heap.