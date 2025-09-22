Timsort is a hybrid sorting algorithm that combines merge sort and insertion sort techniques. Here's how it
works:

1. Finding Runs: Timsort first identifies "runs" - naturally occurring ordered subsequences in the data
2. Handling Runs:
 • If a run is small, it uses insertion sort to expand it to the minimum run size
 • If a run is already in descending order, it reverses it to make it ascending
3. Stack-based Merging:
 • Runs are maintained in a stack
 • When the stack size exceeds certain criteria, merging occurs to keep runs approximately balanced in size
4. Optimizations:
 • Uses galloping mode during merge to speed up comparisons when elements are in similar ranges
 • Minimizes temporary space usage during merge operations


Key advantages:

• Stable sorting (maintains relative order of equal elements)
• Adaptive to existing order in data (performs well on partially sorted data)
• Time complexity: O(n log n) worst case, O(n) best case for already sorted data
• Space complexity: O(n)

Timsort is widely used in:

• Python (since version 2.3)
• Java (since JDK 7)
• Android
• Swift and Rust

It's particularly effective for real-world data that often contains pre-sorted sequences, making it more
efficient than traditional merge sort on such inputs.