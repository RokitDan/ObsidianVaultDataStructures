Binary search is an efficient algorithm for finding a target value in a sorted [[Array]] by repeatedly dividing the search interval in half.

**Key characteristics:**
- Requires sorted input array
- [[Time Complexity]]: [[O(log n) - Logarithmic time]]
- [[Space Complexity]]: [[O(1) - Constant Space]] for iterative, [[O(log n) - Logarithmic Space]] for recursive
- Works by comparing target with middle element and eliminating half of remaining elements

**Algorithm steps:**
1. Compare target with middle element
2. If equal, return index
3. If target is smaller, search left half
4. If target is larger, search right half
5. Repeat until found or interval is empty

Binary search is much more efficient than linear search for sorted data, as it eliminates half the remaining elements with each comparison.