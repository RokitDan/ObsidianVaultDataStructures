When a recursive algorithm executes, each function call creates a new stack
frame that stores:

• Local variables
• Parameters
• Return address

The space complexity is O(h) where h is the maximum recursion depth (call
stack height).

**For example:**

• Linear recursion (like factorial): O(n) space
• Binary tree traversal: O(h) where h is tree height
• Balanced tree: O(log n)
• Skewed tree: O(n)

The [[Stack]] space is the primary memory concern in recursive algorithms, not the input data itself.

O(h) means space grows with recursion depth h, which can be:

• O(log n) for balanced trees
• O(n) for skewed trees

*Linear space would be O(n) where space grows linearly with input size, not*
*recursion depth.*