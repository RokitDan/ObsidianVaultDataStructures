Bucket sort is a distribution sorting algorithm that works by
partitioning an array into smaller "buckets" and then sorting each
bucket individually, often using a different sorting algorithm or
recursively applying bucket sort.

Here's how it works:

1. Create buckets: Divide the range of input values into a fixed number
of buckets
2. Distribute elements: Place each element into the appropriate bucket
based on its value
3. Sort buckets: Sort each bucket individually (using insertion sort or
recursively applying bucket sort)
4. Concatenate: Combine all sorted buckets to get the final sorted array

Time Complexity: O(n + k) average case, where n is the number of
elements and k is the number of buckets Space Complexity: O(n + k)

Bucket sort is most effective when:

• The input is uniformly distributed across a range
• You have a large number of elements to sort
• You can estimate the distribution of data