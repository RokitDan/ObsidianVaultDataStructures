Input space refers to the amount of memory required to store the input data
itself.

**For example:**

• An [[Array]] of n integers requires [[O(n) - Linear Space]] input space
• A string of length n requires [[O(n) - Linear Space]] input space
• A matrix of size n×m requires O(n×m) input space

Input space is often considered separate from [[Auxiliary space]] (additional
memory used by the algorithm beyond input storage). In many cases, input space
is implicit and not counted in the final space complexity analysis, but it's
important to understand that it represents the memory needed to hold the
problem data.

For example, if you're sorting an array of n elements, the input space is
O(n), but the algorithm's space complexity might be [[O(1) - Constant Space]] or [[O(log n) - Logarithmic Space]] depending on whether it's an in-place sort.