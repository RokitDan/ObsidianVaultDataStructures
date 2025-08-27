A stack is a linear data structure that follows the Last In, First Out (LIFO) principle. The last element added to the stack will be the first one to be removed.

**Key operations:**

• Push: Add an element to the top of the stack
• Pop: Remove and return the top element
• Peek/Top: View the top element without removing it
• isEmpty: Check if the stack is empty
• Size: Get the number of elements

**Stacks can be implemented using arrays or linked lists. They're commonly used for:**

• Function call management (call stack)
• Expression evaluation and syntax parsing
• Backtracking algorithms
• Undo operations in applications

**Time Complexity**
- Accessing a specific area in stack is [[O(n) - Linear time]] as each element must be evaluated one by one
	- *There is no indexing as this is not an array or a list
- Inserting/Deleting an element to the stack is [[O(1) - Constant time]] as it comes from the top of the stack
**JavaScript array implementation:**

``` javascript
class Stack {
  constructor() {
    this.items = [];
  }

  // Push element to top
  push(element) {
    this.items.push(element);
  }

  // Pop element from top
  pop() {
    if (this.isEmpty()) return null;
    return this.items.pop();
  }

  // Peek at top element
  peek() {
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

  // Display stack contents
  display() {
    console.log(this.items);
  }
}

// Example usage:
const stack = new Stack();
stack.push(10);
stack.push(20);
stack.push(30);
console.log(stack.peek()); // 30
console.log(stack.pop());  // 30
console.log(stack.size()); // 2
```

In C#, the Stack class is available in the System.Collections.Generic namespace:

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a stack
        Stack<int> stack = new Stack<int>();

        // Push elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Peek at top element
        Console.WriteLine($"Top element: {stack.Peek()}"); // 30

        // Pop elements from the stack
        Console.WriteLine($"Popped: {stack.Pop()}"); // 30
        Console.WriteLine($"Popped: {stack.Pop()}"); // 20

        // Check if stack is empty
        Console.WriteLine($"Is empty: {stack.Count == 0}"); // False

        // Get stack size
        Console.WriteLine($"Stack size: {stack.Count}"); // 1

        // Pop remaining element
        Console.WriteLine($"Popped: {stack.Pop()}"); // 10
        Console.WriteLine($"Is empty: {stack.Count == 0}"); // True
    }
}
```

C# Stack operations:

• Push(item): Add item to top
• Pop(): Remove and return top item
• Peek(): View top item without removing
• Count: Get number of elements
• IsEmpty(): Check if empty (check Count == 0)

The stack follows LIFO (Last In, First Out) principle where the last element added is the first one to be removed.

The LIFO principle makes stacks ideal for scenarios where you need to reverse the order of processing or maintain temporary state.