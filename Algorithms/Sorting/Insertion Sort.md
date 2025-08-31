Bro Code Insertion Sort: https://www.youtube.com/watch?v=8mJ-OhcfpYg

Insertion sort is a simple sorting algorithm that builds the final sorted array one item at a time. It works by iterating through the array and inserting each
element into its correct position among the already-sorted elements.

**Here's how it works:**
1. Start with the second element (index 1)
2. Compare it with elements to its left
3. Shift larger elements to the right
4. Insert the current element in its correct position
5. Repeat until the entire array is sorted

```javascript
function insertionSort(arr) {
  // Start from the second element (index 1)
  for (let i = 1; i < arr.length; i++) {
    let current = arr[i]; // Store the current element to be inserted
    let j = i - 1; // Start comparing with the element before current

    // Move elements larger than current one position to the right
    while (j >= 0 && arr[j] > current) {
      arr[j + 1] = arr[j]; // Shift element to the right
      j--; // Move to the previous element
    }

    // Insert current element at its correct position
    arr[j + 1] = current;
  }

  return arr;
}

```
```javascript
// Example usage:
const numbers = [64, 34, 25, 12, 22, 11, 90];
console.log("Original array:", numbers);
console.log("Sorted array:", insertionSort([...numbers])); // Using spread to avoid mutating original
```

**In this example:**
• We start with 34 (after 64)
• Compare 34 with 64, since 34 < 64, we shift 64 to the right
• Insert 34 in its correct position
• Continue this process for all elements

The time complexity is O(n²) in worst case, but it's efficient for small arrays or nearly sorted data with O(n) best case. It's also stable (maintains relative
order of equal elements) and in-place (requires only O(1) extra memory).
Build qwen3-30b (02:34 PM)