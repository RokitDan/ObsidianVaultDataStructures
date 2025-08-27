O(log n) represents logarithmic time complexity, where the algorithm's runtime grows logarithmically with the input size.

In O(log n) algorithms, the problem size is reduced by a constant factor in each step, typically by eliminating half of the remaining elements.

**Key characteristics

• The algorithm processes or examines only a small portion of the input in each iteration
• Common in divide-and-conquer approaches
• Very efficient for large inputs

**Examples

1. [[Binary Search]] - in each step, eliminate half of the remaining elements
2. Balanced binary search trees (like AVL or Red-Black trees)
3. Some divide-and-conquer algorithms like [[Merge Sort]]

**For instance, with binary search on 1024 elements:

• 1st step: 1024 elements → 512 remaining
• 2nd step: 512 elements → 256 remaining
• 3rd step: 256 elements → 128 remaining
• ...continuing until finding the target

After 10 steps, we've checked all elements (2^10 = 1024). So O(log n) means the number of operations needed grows much slower than the input size.

This makes algorithms like binary search extremely efficient, as searching 1 billion items only requires about 30 operations.