Space complexity measures the amount of memory space an algorithm or data structure requires as input size grows.

It's expressed using Big O notation, just like time complexity.

**Key aspects:**

• [[Auxiliary space]] - Extra space used by the algorithm
• [[Input space]] - Space required to store input data
• [[Total space]] - Sum of auxiliary and input space

**Common examples:**

• Array of size n: O(n) space complexity
• 2D matrix n×n: O(n²) space complexity
• Linked list of size n: O(n) space complexity
• Recursion stack: O(h) where h is recursion depth

**Space complexity matters for:**

• Memory usage optimization
• Handling large datasets
• Understanding resource requirements
• Designing efficient algorithms

[[Big O Notation]] is used identically for both time and space complexity - it's just a mathematical notation for describing growth rates.

**The difference is:**

• Time complexity O(f(n)): How execution time grows with input size
• Space complexity O(f(n)): How memory usage grows with input size

**For example, an algorithm that:**

• Takes O(n) time to process n elements
• Uses O(n) space for storage

Same Big O notation, but different types of resources being measured.

The mathematical analysis and rules are identical - it's just applied to different metrics (time vs memory).

So yes, Big O notation itself is the same, but it measures different things in each context.