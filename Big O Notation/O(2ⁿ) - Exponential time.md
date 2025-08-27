O(2^n) represents exponential time complexity, where the algorithm's runtime grows exponentially with the input size.

**In O(2^n) algorithms:**

• The number of operations doubles for each additional element in the input
• Common in recursive algorithms that solve problems by exploring all possible combinations
• Generally inefficient for large inputs

**Key characteristics:**

• Very slow growth rate - even small inputs cause massive computation
• Often found in brute force approaches
• Not practical for large datasets due to exponential growth

**Common examples:**

1. Recursive Fibonacci calculation without memoization
2. Generating all subsets of a set (2^n subsets)
3. Recursive algorithms that make two recursive calls at each step
4. Brute force solutions to NP-complete problems

**For instance, with input size 10:**

• O(2^n) = 2^10 = 1,024 operations

**With input size 20:**

• O(2^n) = 2^20 = 1,048,576 operations

This represents a rapid growth where doubling the input size causes the runtime to increase by a factor of 4 (2^2). For example, with n=10 it takes 1,024
operations, but with n=20 it takes over 1 million operations.

Algorithms with O(2^n) complexity are typically only practical for very small inputs or when optimization techniques like memoization or dynamic programming are
applied to reduce complexity.