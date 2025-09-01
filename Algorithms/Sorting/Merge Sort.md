https://youtu.be/3j0SWDX4AtU

![[MergeSort.png]]
![[MergeSort2.png]]
Merge sort is a divide-and-conquer sorting algorithm that works by recursively
splitting the [[Array]] into halves, sorting each half, then merging them back together.

#### How it works:
1. Divide: Split the [[Array]] into two halves
2. Conquer: Recursively sort both halves
3. Combine: Merge the two sorted halves back together

#### Key characteristics:
• Time complexity: [[O(n log n) - Linearithmic time]] in all cases
• Space complexity: [[O(n) - Linear Space]]
• Stable sorting algorithm (maintains relative order of equal elements)
• Not in-place (requires additional memory)
#### Example process:
```
[38, 27, 43, 3]
   ↓
[38, 27] [43, 3]
   ↓        ↓
[38] [27] [43] [3]
   ↓      ↓
[27, 38] [3, 43]
   ↓
[3, 27, 38, 43]
```

#### Advantages:
• Consistent O(n log n) performance
• Stable sorting
• Works well with external sorting (large datasets)
• Predictable performance

#### Disadvantages:
• Requires O(n) extra space
• Not adaptive (doesn't perform better on nearly sorted data)
• Slower than [[Quick Sort]]in practice due to higher constant factors

The algorithm is particularly useful when you need guaranteed performance or
stability in sorting.

Here's a JavaScript implementation of merge sort:

```javascript
function mergeSort(arr) {
  // Base case: arrays with 0 or 1 element are already sorted
  if (arr.length <= 1) {
    return arr;
  }

  // Divide: split array into two halves
  const mid = Math.floor(arr.length / 2);
  const left = arr.slice(0, mid);
  const right = arr.slice(mid);

  // Conquer: recursively sort both halves
  return merge(mergeSort(left), mergeSort(right));
}

function merge(left, right) {
  let result = [];
  let leftIndex = 0;
  let rightIndex = 0;

  // Compare elements from both arrays and merge in sorted order
  while (leftIndex < left.length && rightIndex < right.length) {
    if (left[leftIndex] <= right[rightIndex]) {
      result.push(left[leftIndex]);
      leftIndex++;
    } else {
      result.push(right[rightIndex]);
      rightIndex++;
    }
  }

  // Add remaining elements
  return result.concat(left.slice(leftIndex)).concat(right.slice(rightIndex));
}

// Example usage:
const array = [38, 27, 43, 3, 9, 82, 10];
console.log("Original array:", array);
console.log("Sorted array:", mergeSort(array));
```

**When you run this code, it will output:**
```
Original array: [ 38, 27, 43, 3, 9, 82, 10 ]
Sorted array: [ 3, 9, 10, 27, 38, 43, 82 ]
```

The algorithm works by recursively dividing the array in half until we have single
elements, then merging them back together in sorted order. This approach guarantees
O(n log n) time complexity.