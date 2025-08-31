Depth-First Search (DFS) is a [[Graph]] traversal algorithm that explores as far as possible along each branch before backtracking.

Key characteristics:

- Uses a [[Stack]] (LIFO) data structure
- Visits vertices by going deep into one path before exploring alternatives
- Can be implemented recursively or iteratively with a stack
- [[Time Complexity]]: O(V + E) where V is vertices and E is edges
- [[Space Complexity]]: O(V)

DFS is useful for:

- Finding connected components
- Detecting cycles
- Topological sorting
- Maze solving
- Tree and graph traversal

Unlike [[Breadth-First Search (BFS)]] which explores level by level, DFS goes deep into one path before backtracking to explore other branches.