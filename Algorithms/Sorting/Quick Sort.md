Quick sort is a divide-and-conquer sorting algorithm that works by selecting a
'pivot' element and partitioning the array around it.

## How it works:

1. Choose pivot: Select an element from the array (often first, last, or middle element)
2. Partition: Rearrange array so elements smaller than pivot come before it, and larger elements come after
3. Recursively sort: Apply the same process to the sub-arrays on both sides of the pivot

#### Key characteristics:

- Time complexity: [[O(n log n) - Linearithmic time]] average case, [[O(n²) - Quadratic time]] worst case
- Space complexity: [[O(log n) - Logarithmic Space]] due to recursion stack
- Not stable (doesn't maintain relative order of equal elements)
- In-place sorting algorithm (requires minimal additional memory)

#### Example process:

```
[38, 27, 43, 3, 9, 82, 10]
    ↓ (pivot = 38)
[27, 3, 9, 10] [43, 82]
    ↓           ↓
[3, 9, 10] [27] [43] [82]
    ↓
[3, 9, 10, 27, 38, 43, 82]
```

#### Advantages:
- Generally faster than [[Merge Sort]] in practice
- In-place sorting (low memory usage)
- Cache-efficient due to good locality of reference

#### Disadvantages:
- Worst-case [[O(n²) - Quadratic time]] time complexity
- Not stable
- Performance depends heavily on pivot selection

Quick sort is widely used in practice due to its efficiency and good average-case

Here's a JavaScript implementation of quick sort:

``` javascript
function quickSort(arr, low = 0, high = arr.length - 1) {
  if (low < high) {
    // Partition the array and get pivot index
    const pivotIndex = partition(arr, low, high);

    // Recursively sort elements before and after partition
    quickSort(arr, low, pivotIndex - 1);
    quickSort(arr, pivotIndex + 1, high);
  }
  return arr;
}

function partition(arr, low, high) {
  // Choose the rightmost element as pivot
  const pivot = arr[high];

  // Index of smaller element (indicates right position of pivot)
  let i = low - 1;

  for (let j = low; j < high; j++) {
    // If current element is smaller than or equal to pivot
    if (arr[j] <= pivot) {
      i++;
      // Swap elements
      [arr[i], arr[j]] = [arr[j], arr[i]];
    }
  }

  // Place pivot in its correct position
  [arr[i + 1], arr[high]] = [arr[high], arr[i + 1]];
  return i + 1;
}

// Example usage:
const array = [38, 27, 43, 3, 9, 82, 10];
console.log("Original array:", array);
console.log("Sorted array:", quickSort(array));
```

When you run this code, it will output:

```
Original array: [ 38, 27, 43, 3, 9, 82, 10 ]
Sorted array: [ 3, 9, 10, 27, 38, 43, 82 ]
```
The algorithm works by selecting a pivot element (in this case, the last element),
partitioning the array so elements smaller than the pivot come before it and larger
elements come after, then recursively applying the same process to the sub-arrays on
both sides of the pivot.
