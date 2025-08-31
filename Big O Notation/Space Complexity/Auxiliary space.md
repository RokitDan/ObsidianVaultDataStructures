Auxiliary space refers to the extra memory space used by an algorithm beyond
what is needed for the input data.

**This includes:**

• Temporary variables
• Recursive call [[Stack]]
• Additional data structures created during execution

**For example:**

• In-place algorithms: [[O(1) - Constant Space]] auxiliary space (like [[Bubble Sort]])
• [[Merge Sort]]: [[O(n) - Linear Space]] auxiliary space (for temporary [[Array]]s)
• Recursive [[Quick Sort]]: [[O(log n) - Logarithmic Space]] auxiliary space (for call [[Stack]])

Auxiliary space is what's typically analyzed when calculating space
complexity, as it represents the actual extra memory burden of the algorithm
beyond just storing the input.