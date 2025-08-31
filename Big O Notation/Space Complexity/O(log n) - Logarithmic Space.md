O(log n) space complexity occurs when the memory usage grows logarithmically with
the input size.

This commonly happens in algorithms that use recursion with divide-and-conquer
approaches, or when maintaining a small amount of data that grows slowly with input
size.

Examples include:

- [[Binary Search]] (recursive implementation)
- [[Merge Sort ]](recursive calls)
- Balanced binary search trees
- [Heap] operations

The key is that the space used doesn't grow linearly with input, but rather grows
much more slowly (logarithmically). For instance, if you double the input size, the
space usage might only increase by a small constant amount.

This is generally considered efficient space complexity, better than O(n) but worse
than O(1).