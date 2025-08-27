Linearithmic time complexity O(n log n) occurs when an algorithm's runtime grows proportionally to n times the logarithm of n.

**This complexity typically arises in:**

• Divide-and-conquer algorithms
• Sorting algorithms that split problems into smaller subproblems
• Algorithms that process each element while also requiring logarithmic operations

**Common examples:**

1. [[Merge Sort]] - divides array in half recursively (log n levels) and merges in O(n) time at each level
2. [[Quick sort]] - average case with O(n log n) performance
3. [[Heap Sort]] - builds heap in O(n log n) time
4. Some graph algorithms like Dijkstra's with binary heaps

The key characteristic is that the algorithm processes each element (n) but also performs operations that scale logarithmically with input size.

**For example, with 1000 elements:**

• O(n log n) = 1000 × log₂(1000) ≈ 1000 × 10 = 10,000 operations

This complexity is much better than O(n²) for large inputs because the logarithmic factor grows very slowly. It represents a good balance between efficiency and
practical implementation.

Many of the most efficient general-purpose sorting algorithms achieve O(n log n) complexity, making this a desirable target for algorithm design.