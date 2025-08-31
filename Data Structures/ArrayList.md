https://youtu.be/r51TRDECIw4?t=149

**An ArrayList is a dynamic array data structure that provides:**

- Dynamic sizing: Can grow and shrink as elements are added/removed
- Random access: [[O(1) - Constant time]] time complexity for accessing elements by index
- Sequential storage: Elements stored in contiguous memory locations
- Type safety: Usually typed to store specific data types

**Key characteristics:**

- Resizes automatically when capacity is exceeded
- Provides methods for adding, removing, and accessing elements
- Maintains insertion order
- Allows duplicate values

**Time Complexities:**

- Access by index: [[O(1) - Constant time]]
- Insertion/Deletion at end: [[O(1) - Constant time]] average
- Insertion/Deletion in middle: [[O(n) - Linear time]]
- Search: [[O(n) - Linear time]]

```C#
// Creating a List (ArrayList equivalent in C#)
List<int> numbers = new List<int>();

// Adding elements
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

// Accessing elements by index
int first = numbers[0]; // Returns 10

// Inserting at specific position
numbers.Insert(1, 15); // Inserts 15 at index 1

// Removing elements
numbers.Remove(20); // Removes first occurrence of 20
numbers.RemoveAt(0); // Removes element at index 0

// Checking size
int count = numbers.Count;

// Iterating through elements
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

In C#, ArrayLists are implemented using the List<T> class. The List<T> class in C# provides dynamic sizing, automatic resizing, and fast random access while maintaining the benefits of array-like storage.

**Common implementations:**

- C#: List<T> class
- Java: ArrayList class
- Python: list built-in (dynamically resized array)
- JavaScript: Array object


