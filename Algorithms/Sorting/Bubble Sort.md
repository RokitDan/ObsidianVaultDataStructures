Bubble sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements and swaps them if they are in the wrong order. The
pass through the list is repeated until the list is sorted.

The algorithm gets its name because smaller elements "bubble" to the top of the list (beginning), while larger elements settle toward the bottom (end).

Here's how it works in JavaScript:

```javascript
function bubbleSort(arr) {
  let n = arr.length;

  // Traverse through all array elements
  for (let i = 0; i < n - 1; i++) {
    // Flag to optimize - if no swaps occur, array is sorted
    let swapped = false;

    // Last i elements are already in place
    for (let j = 0; j < n - i - 1; j++) {
      // Swap if the element found is greater than the next element
      if (arr[j] > arr[j + 1]) {
        // Swap elements using ES6 destructuring
        [arr[j], arr[j + 1]] = [arr[j + 1], arr[j]];
        swapped = true;
      }
    }

    // If no swapping occurred, array is sorted
    if (!swapped) break;
  }

  return arr;
}

// Example usage:
const numbers = [64, 34, 25, 12, 22, 11, 90];
console.log("Original array:", numbers);
console.log("Sorted array:", bubbleSort([...numbers]));
```

Here's a C# implementation of bubble sort:

```C#
using System;

class BubbleSort
{
    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        // Traverse through all array elements
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

            // Last i elements are already in place
            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no swapping occurred, array is sorted
            if (!swapped)
                break;
        }
    }

    static void Main()
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        foreach (int num in numbers)
            Console.Write(num + " ");

        BubbleSortAlgorithm(numbers);

        Console.WriteLine("\nSorted array:");
        foreach (int num in numbers)
            Console.Write(num + " ");
    }
}
```

This C# implementation:

• Uses nested loops to compare adjacent elements
• Swaps elements when they're in wrong order
• Includes optimization to stop early if no swaps occur
• Has O(n²) time complexity in worst case
• Uses O(1) space complexity (sorts in-place)

The algorithm repeatedly steps through the array, compares adjacent elements, and swaps them if they're in the wrong order, gradually moving larger elements toward
the end.

**Key characteristics:**

• Time complexity: O(n²) worst case, O(n) best case (already sorted)
• Space complexity: O(1) - sorts in-place
• Stable: Equal elements maintain their relative order
• Adaptive: Performs better on partially sorted arrays

The algorithm repeatedly compares adjacent elements and moves larger ones toward the end of the array, "bubbling" them up like air bubbles rising in water.