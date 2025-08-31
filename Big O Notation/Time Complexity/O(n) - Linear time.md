- As data increases, time to complete increases at a linear rate
- O(n) represents linear time complexity, where the algorithm's runtime grows directly proportional to the input size.

**In O(n) algorithms:

- Each element in the input is processed or examined exactly once
- The number of operations increases linearly with input size
- It's the most common and generally acceptable complexity for many algorithms

**Examples:

1. Linear search through an [[Array]]
2. Finding the maximum element in an unsorted array
3. Iterating through all elements to perform an operation
4. Simple loops that process each item once

**For instance, if you have an array of 100 elements:

- O(n) means up to 100 operations
- If input size doubles to 200 elements, operations roughly double to 200

This is efficient for many practical purposes and represents a reasonable trade-off between simplicity and performance. Algorithms with O(n) complexity are
considered "good" for most use cases, as they scale reasonably well with input size.

The key characteristic is that the algorithm processes each element once, making it predictable and efficient for reasonably sized inputs.