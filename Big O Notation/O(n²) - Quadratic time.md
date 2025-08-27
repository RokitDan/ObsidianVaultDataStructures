Quadratic time complexity O(n²) occurs when an algorithm's runtime grows proportionally to the square of the input size.

This occurs when an item in a dataset needs to interact will all other items in a data set. Imagine if a students in a classroom needed to shake hands with all other students in the classroom

**This happens when:

• For each element in the input, the algorithm processes or compares with every other element
• Nested loops are used where both loops iterate over the entire input
• Each element is examined multiple times

**Common examples:

1. [[Bubble Sort]], [[Selection Sort]], [[Insertion Sort]] (with nested loops)
2. Finding all pairs of elements in an [[Array]]
3. Simple nested loops that iterate through all combinations
4. Matrix multiplication algorithms

**For instance, with an array of 100 elements:**

- O(n²) means up to 10,000 operations (100 × 100)
- If input size doubles to 200 elements, operations increase to 40,000 (200 × 200)

This makes O(n²) algorithms inefficient for large datasets - if input size increases by 10x, runtime increases by 100x.

Quadratic time complexity is generally considered poor for large inputs, and more efficient O(n log n) or O(n) algorithms are preferred when available. However,
O(n²) is acceptable for small inputs or when simpler implementation is more important than optimal performance.