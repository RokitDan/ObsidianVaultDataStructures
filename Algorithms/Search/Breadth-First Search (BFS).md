Breadth-First Search (BFS) is a [[Graph]] traversal algorithm that explores all vertices at the current depth level before moving to vertices at the next depth level.

Key characteristics:

- Uses a [[Queue]] (FIFO) data structure
- Visits vertices level by level from the source
- Finds shortest path in unweighted graphs
- [[Time Complexity]]: O(V + E) where V is vertices and E is edges
- [[Space Complexity]]: O(V)

BFS explores all neighbors of a vertex before exploring their neighbors, making it useful for finding shortest paths in unweighted graphs or checking if a graph is bipartite.