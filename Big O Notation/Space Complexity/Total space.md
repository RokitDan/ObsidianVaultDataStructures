Total space in space complexity analysis is the sum of input space and auxiliary space.

Formula: Total Space = Input Space + Auxiliary Space

**For example:**

• [[Array]] sorting: [[O(n) - Linear Space]] input space + [[O(1) - Constant Space]] auxiliary space = O(n) total space
• [[Merge Sort]]: O(n) input space + O(n) auxiliary space = O(n) total space

In most algorithm analysis, we focus primarily on auxiliary space because input space is often considered implicit and unavoidable. However, total space gives the complete picture of memory usage including both input data and algorithm overhead.

For most practical purposes, when we say an algorithm uses O(n) space, we typically mean O(n) [[Auxiliary space]], not total space.