https://www.youtube.com/watch?v=-VgHk7UMPP4

 Graphs are mathematical structures consisting of nodes (vertices) connected by edges. They're used to model relationships
between objects.

**Key concepts:**

• Nodes/Vertices - The objects being connected
• Edges - The connections between nodes
• Directed vs Undirected - Edges can have direction or be bidirectional
• Weighted vs Unweighted - Edges can have values/weights

**Common graph representations:**

• Adjacency List - Each node stores list of connected nodes
• Adjacency Matrix - 2D matrix showing connections

**Common algorithms:**

• Breadth-First Search (BFS) - Explores neighbors level by level
• Depth-First Search (DFS) - Explores as far as possible down a path
• Dijkstra's Algorithm - Finds shortest path in weighted graphs

**Graphs are used for:**

• Social networks
• Maps and navigation
• Web page linking
• Dependency resolution


## Undirected Graphs

https://youtu.be/-VgHk7UMPP4?t=9

![[Screenshot 2025-08-30 at 12.04.35 PM.png]]

Undirected graphs are graphs where edges have no direction - if there's an edge between nodes A and B, you can traverse from A
to B or B to A.

**Key characteristics:**

• Symmetric edges - If edge (A,B) exists, then (B,A) also exists
• Bidirectional - Movement is possible in both directions between connected nodes
• No ordering - No concept of "from" or "to" in edges

**Representations:**

• Adjacency List - Each node stores neighbors (e.g., A: B,C means A connects to B and C)
• Adjacency Matrix - Matrix where matrix[i][j] = 1 if nodes i and j are connected

**Common operations:**

• Add edge - Connect two nodes
• Remove edge - Disconnect two nodes
• Find neighbors - Get all nodes connected to a given node
• Check connection - Determine if two nodes are connected

**Applications:**

• Social networks (friendship bidirectional)
• Networks and communication systems
• Map applications (bidirectional roads)

## Directed Graph

https://youtu.be/-VgHk7UMPP4?t=94

![[Screenshot 2025-08-30 at 12.04.00 PM.png]]

Directed graphs (digraphs) are graphs where edges have direction - they're ordered pairs representing one-way connections.

**Key characteristics:**

• Asymmetric edges - If edge (A,B) exists, (B,A) might not exist
• Directional - Movement is only possible in the specified direction
• Edges have "from" and "to" - A → B means you can go from A to B, but not necessarily vice versa

**Representations:**

• Adjacency List - Each node stores outgoing neighbors (e.g., A: B,C means A has edges to B and C)
• Adjacency Matrix - Matrix where matrix[i][j] = 1 if there's an edge from node i to j

**Common operations:**

• Add directed edge - Create one-way connection A → B
• Remove edge - Delete a directional connection
• Find outgoing neighbors - Get nodes reachable from a given node
• Find incoming neighbors - Get nodes that can reach a given node

**Applications:**

• Social media following (A follows B, but B might not follow A back)
• Web page links (A links to B, but B doesn't link to A)
• Task dependencies (Task A must finish before Task B starts)
• Traffic flow (One-way streets)

## Adjacency Matrix

https://youtu.be/-VgHk7UMPP4?t=110

![[Screenshot 2025-08-30 at 12.03.11 PM.png]]

An adjacency matrix is a 2D array representation of a graph where rows and columns represent nodes, and the values indicate
whether edges exist between pairs of nodes.

**For an undirected graph with n nodes:**

• Matrix size is n×n
• If there's an edge between node i and j, matrix[i][j] = 1
• If no edge exists, matrix[i][j] = 0

**For a directed graph:**

• Same format but only one direction is marked
• If there's an edge A → B, matrix[A][B] = 1

**Example (undirected graph with 3 nodes):**

```
   A B C
A  0 1 1
B  1 0 1
C  1 1 0
```

**Advantages:**

• Fast edge existence checks [[O(n) - Linear time]]
• Easy to implement and understand
• Good for dense graphs

**Disadvantages:**

• Uses [[O(n²) - Quadratic time]] space regardless of edges
• Can be inefficient for sparse graphs

## Adjacency List

https://youtu.be/-VgHk7UMPP4?t=193

![[Screenshot 2025-08-30 at 12.02.30 PM.png]]

An adjacency list is a collection of lists where each list describes the set of neighbors for each node in a graph.

**For an undirected graph with n nodes:**

• Each node has its own list containing connected neighbor nodes
• If node A connects to B and C, the list for A contains 
```
[B,C]
```

**For a directed graph:**

• Each node's list only contains outgoing neighbors
• If A → B and A → C, the list for A contains
```
[B,C]
```

**Example representation:**

```
A: [B, C]
B: [A, C]
C: [A, B]
```

**Advantages:**

• Space efficient (O(V+E) where V=vertices, E=edges)
• Fast to iterate through neighbors of a specific node
• Good for sparse graphs

**Disadvantages:**

• Slower to check if an edge exists between two specific nodes (O(degree))
• Slightly more complex to implement than adjacency matrix

This is the most commonly used graph representation in practice.

 ### ***Adjacency lists are related to [[Array]] and [[ArrayList]] in implementation:***

**Arrays as underlying storage:**

• An adjacency list can be implemented using arrays
• Each node's neighbor list is stored in an array
• Index positions can represent node identifiers

**ArrayLists (Dynamic Arrays):**

• In programming languages like Java or Python, adjacency lists are often implemented using ArrayLists (dynamic arrays)
• Each node has an ArrayList storing its neighbors
• ArrayLists can grow dynamically as more neighbors are added

**Example in pseudocode:**

```Pseudo
// Using arrays
adjacencyList = new int[n][];  // Array of arrays

// Using ArrayLists
adjacencyList = new ArrayList[n];  // Array of ArrayLists
for (int i = 0; i < n; i++) {
    adjacencyList[i] = new ArrayList<>();
}
```

Key difference from arrays in graph representation:

• Regular arrays (like adjacency matrices) have fixed size and store all connections
• Adjacency lists use arrays/ArrayLists as containers but only allocate space for actual neighbors

This makes adjacency lists more memory-efficient than matrices for sparse graphs where not all nodes are connected to every other node.


