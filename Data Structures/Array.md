https://youtu.be/r51TRDECIw4?t=39
https://youtu.be/O9v10jQkm5c?t=260

An array is a fundamental data structure that stores a collection of elements, typically of the same type, in contiguous memory locations. Arrays provide indexed access to elements and have a fixed or dynamic size. Arrays are often processed with for loops which is a type of [[Linear Search]]

**Key characteristics:**

- Elements are stored in sequential memory locations
- Each element in the array has an index
- Access elements by index (0-based)
- Size can be fixed or dynamic (in JavaScript)
- Elements can be of any data type
- Supports random access ([[O(1) - Constant time]] time complexity for accessing elements)
- Finding an element at a given index is extremely fast
- Arrays are efficient for accessing elements by index but can be inefficient for inserting/removing elements in the middle due to shifting operations.

**Time Complexity**:

- Accessing or replacing an Item [[O(1) - Constant time]]
- Inserting and increasing array size [[O(n) - Linear time]]: the entire array needs to be copied, the new item needs to be inserted, and the old array needs to be entirely replaced
	- *The longer the array is, the longer the copy operation will take*
- Removing element [[O(n) - Linear time]]: the element needs to be removed and then all subsequent elements must me moved one position to the left in the array.
	- *The more elements that need to be moved, the longer this operation will take*

**JavaScript arrays are dynamic and can grow or shrink as needed:**

```javascript
// Creating arrays
const fruits = ['apple', 'banana', 'orange']; // String array
const numbers = [1, 2, 3, 4, 5]; // Number array
const mixed = [1, 'hello', true, null]; // Mixed type array

// Basic operations
console.log(fruits[0]); // Access first element: 'apple'
fruits.push('grape'); // Add element to end
fruits.pop(); // Remove last element
fruits.unshift('mango'); // Add element to beginning
fruits.shift(); // Remove first element

// Array methods
const doubled = numbers.map(x => x * 2); // [2, 4, 6, 8, 10]
const evens = numbers.filter(x => x % 2 === 0); // [2, 4]
const sum = numbers.reduce((acc, x) => acc + x, 0); // 15

// Array traversal / linear search
for (let i = 0; i < fruits.length; i++) {
  console.log(fruits[i]);
}

// Or using forEach
fruits.forEach((fruit, index) => {
  console.log(`${index}: ${fruit}`);
});
```

