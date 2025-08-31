https://youtu.be/r51TRDECIw4?t=751

A tree is a hierarchical data structure consisting of nodes, where each node has a value and may
have zero or more child nodes. The topmost node is called the root, and nodes with no children
are called leaves.

Key characteristics:

- Hierarchical organization
- Each node (except root) has exactly one parent
- Nodes can have zero or more children
- No cycles (no node can be its own ancestor)
- Path from root to any node is unique

**Common types:**
- Binary trees (each node has at most 2 children)
- [[Binary Search Tree]] (left children < parent, right children > parent)
- Balanced trees (AVL, Red-Black)

**Applications:**
- File systems
- Decision making
- Expression parsing
- Hierarchical data representation

**Time Complexity**
Trees support efficient operations like search, insertion, and deletion (O(log n) in balanced trees).

**Time complexity for tree operations depends on the tree type and structure:**
- Search: [[O(log n) - Logarithmic time]] for balanced trees (AVL, Red-Black), [[O(n) - Linear time]] for unbalanced trees
- Insertion: [[O(log n) - Logarithmic time]], [[O(n) - Linear time]] for unbalanced trees
- Deletion:  [[O(log n) - Logarithmic time]], [[O(n) - Linear time]]  for unbalanced trees

For [[Binary Search Tree]]:

- Best case (balanced): All operations  [[O(log n) - Logarithmic time]]
- Worst case (skewed): All operations [[O(n) - Linear time]] 

The logarithmic complexity comes from the tree's height being O(log n) when balanced.

Here's an example of recursive tree traversal in C#:

```C#
public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public static void InOrderTraversal(TreeNode root)
{
    if (root != null)
    {
        InOrderTraversal(root.Left);   // Visit left subtree
        Console.Write(root.Value + " "); // Process current node
        InOrderTraversal(root.Right);  // Visit right subtree
    }
}

public static void PreOrderTraversal(TreeNode root)
{
    if (root != null)
    {
        Console.Write(root.Value + " "); // Process current node
        PreOrderTraversal(root.Left);   // Visit left subtree
        PreOrderTraversal(root.Right);  // Visit right subtree
    }
}

public static void PostOrderTraversal(TreeNode root)
{
    if (root != null)
    {
        PostOrderTraversal(root.Left);  // Visit left subtree
        PostOrderTraversal(root.Right); // Visit right subtree
        Console.Write(root.Value + " "); // Process current node
    }
}
```

**This demonstrates recursive depth-first traversal techniques:**
- In-order: Left → Root → Right
- Pre-order: Root → Left → Right
- Post-order: Left → Right → Root

Each recursive call processes a subtree until reaching null nodes (base case).

**Here's an example of filesystem traversal in C# using DirectoryInfo and FileSystemInfo:**

```C#
using System;
using System.IO;

public static void TraverseDirectory(string path)
{
    try
    {
        var directory = new DirectoryInfo(path);

        // Process current directory
        Console.WriteLine($"Directory: {directory.FullName}");

        // List all files in current directory
        foreach (var file in directory.GetFiles())
        {
            Console.WriteLine($"  File: {file.Name} ({file.Length} bytes)");
        }

        // Recursively process subdirectories
        foreach (var subDir in directory.GetDirectories())
        {
            TraverseDirectory(subDir.FullName);
        }
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("Access denied to directory");
    }
}
```

**This code:**
1. Creates a DirectoryInfo object for the target path
2. Lists all files in the current directory
3. Recursively processes each subdirectory
4. Handles access denied exceptions gracefully

The traversal uses the .NET FileSystemInfo class to safely enumerate files and directories without modifying system state. This approach is safe as it only reads filesystem metadata and does not write or change any files.
