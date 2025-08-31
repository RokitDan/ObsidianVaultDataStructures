https://mariusniemet20.medium.com/big-o-notation-time-space-complexity-7d850c3a340f

Big O notation explained: https://youtu.be/O9v10jQkm5c?t=30

Big-O Notation in 100 Seconds - Fireship: https://www.youtube.com/watch?v=g2o22C3CRfU

![[Big O Image.png]]

- Measures speed and efficiency in programming
- Evaluates how data structurers are performing
- Different Data structures are optimized for different scenarios
- Data structures are measured in time complexity

Big O notation is a mathematical way to describe the efficiency or complexity of an algorithm, specifically how its runtime or space requirements grow as the input size increases.

It describes the upper bound (worst-case scenario) of an algorithm's time or space complexity. The notation uses "O" followed by a mathematical expression showing
how the algorithm scales.

### Key aspects:

• Focuses on the dominant term as input size approaches infinity
• Ignores constants and lower-order terms
• Provides worst-case analysis (most common use case)
• Helps compare algorithms' efficiency

---
### Time vs Space Complexity

[[Big O Notation]] is used identically for both [[Time Complexity]] and [[Space Complexity]] - it's just a mathematical notation for describing growth rates.

**The difference is:**

• Time complexity O(f(n)): How execution time grows with input size
• Space complexity O(f(n)): How memory usage grows with input size

**For example, an algorithm that:**

• Takes O(n) time to process n elements
• Uses O(n) space for storage

Same Big O notation, but different types of resources being measured.

The mathematical analysis and rules are identical - it's just applied to different metrics (time vs memory).

So yes, Big O notation itself is the same, but it measures different things in each context.

---
### Time
**Common Big O time complexities from fastest to slowest:*

1. [[O(1) - Constant time]]
2. [[O(log n) - Logarithmic time]]
3. [[O(n) - Linear time]]
4. [[O(n log n) - Linearithmic time]]
5. [[O(n²) - Quadratic time]]
6. [[O(2ⁿ) - Exponential time]]

Big O analysis helps developers make informed decisions about which algorithms to use based on expected input sizes and performance requirements.

---
### Space 
**Here are the common Big O notations relevant to space complexity:**

- [[O(1) - Constant Space]]
- [[O(n) - Linear Space]]
- [[O(n²) - Quadratic Space]]
- [[O(log n) - Logarithmic Space]]
- [[O(n log n) - Linearithmic Space]]
- [[O(2ⁿ) - Exponential Space]]

