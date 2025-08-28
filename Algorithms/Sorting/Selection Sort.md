Bro Code Selection Sort: https://www.youtube.com/watch?v=EwjnF7rFLns

Selection sort is a simple comparison-based sorting algorithm that divides the input array into two parts: a sorted portion at the left and an unsorted portion
at the right.

The algorithm works by:

1. Finding the minimum element in the unsorted portion
2. Swapping it with the first element of the unsorted portion
3. Moving the boundary between sorted and unsorted portions one position to the right
4. Repeating until the entire array is sorted

Here's a JavaScript implementation:

``` javascript
function selectionSort(arr) {
  // Traverse through all array elements
  for (let i = 0; i < arr.length - 1; i++) {
    let minIndex = i; // Assume the first element is the smallest

    // Find the minimum element in remaining unsorted array
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[minIndex]) {
        minIndex = j; // Update the index of minimum element
      }
    }

    // Swap the found minimum element with the first element
    if (minIndex !== i) {
      [arr[i], arr[minIndex]] = [arr[minIndex], arr[i]]; // ES6 destructuring swap
    }
  }

  return arr;
}

// Example usage:
const numbers = [64, 34, 25, 12, 22, 11, 90];
console.log("Original array:", numbers);
console.log("Sorted array:", selectionSort([...numbers])); // Using spread to avoid mutating original
```

In this example:

• Pass 1: Find minimum (11) and swap with first element (64)
• Pass 2: Find minimum in remaining (12) and swap with second element (34)
• Continue until sorted

Time complexity: O(n²) in all cases Space complexity: O(1) - sorts in-place It's not stable (doesn't preserve relative order of equal elements) but is simple
to
understand and implement.

The algorithm performs n-1 passes, making it less efficient than insertion sort for small arrays but more predictable in performance.