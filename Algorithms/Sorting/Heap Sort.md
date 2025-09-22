Heap sort is a comparison-based sorting algorithm that uses a binary heap data structure.

Here's how it works:

1. Build a max heap from the input [[Array]] - this ensures the largest element is at the root
2. Extract elements one by one:
 - Swap the root (largest element) with the last element
 - Reduce heap size by one
 - Heapify the root to maintain max-heap property


The algorithm has O(n log n) time complexity in all cases (best, average, worst) and O(1) space complexity,
making it very predictable in performance.

It's particularly useful when you need guaranteed O(n log n) performance, as it doesn't have the worst-case O(n²)
behavior like quicksort.