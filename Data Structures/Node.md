**A node typically contains:**
- Data - The actual information stored
- Pointers/References - Links to other nodes (next, parent, children, etc.)

**In the context of [[Graph]] and [[Tree]]:**
- Each node represents a vertex
- Node structure often includes data and connections to neighboring nodes

**So while a node itself is simple, it's a building block that enables more complex data structures like:**
- [[List (Linked List)]] (each node has one pointer to next node)
- [[Tree]] (each node has pointers to child nodes)
- [[Graph]] (each node stores its neighbors)

In C#, nodes are typically implemented as classes or structs:

```C#
// Basic node for a linked list
public class ListNode
{
    public int Data { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int data)
    {
        Data = data;
        Next = null;
    }
}

// Node for a binary tree
public class TreeNode
{
    public int Data { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

// Node for a graph
public class GraphNode
{
    public int Data { get; set; }
    public List<GraphNode> Neighbors { get; set; }

    public GraphNode(int data)
    {
        Data = data;
        Neighbors = new List<GraphNode>();
    }
}
```

Nodes in C# are reference types (classes) that can be dynamically allocated and connected through references.