Linear search (also called sequential search) is a simple searching algorithm that checks every element in a list or array until it finds the target value or reaches the end.

**How it works:**
1. Start at the first element of the [[Array]]
2. Compare the current element with the target value
3. If match found, return the index
4. If no match, move to the next element
5. Repeat until end of array or target found

**Pseudocode:**
```
function linearSearch(array, target):
    for i = 0 to length(array) - 1:
        if array[i] == target:
            return i
    return -1  // not found
```

[[Time Complexity]]: [[O(n) - Linear time]]where n is the number of elements Space Complexity: O(1)

**When to use:**
• Small datasets
• Unsorted data
• When you only need to search once
• When simplicity is preferred over efficiency

Linear search is straightforward but inefficient for large datasets compared to [[Binary Search]].
