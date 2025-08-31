https://youtu.be/O9v10jQkm5c?t=759

```
	   50
      /  \
    30    70
   / \   / \
  20 40 60 80
 /     /   / \
10   55  65   90
```

**This is a binary search tree with the following properties:**
- Root node contains 50
- Left subtree of 50 contains values less than 50 (30, 20, 10, 40, 55, 60, 65, 80, 90)
- Right subtree of 50 contains values greater than 50 (70, 60, 80, 65, 90)
- Each node follows the BST property where left children are smaller and right children are larger

**A Binary Search Tree (BST) is a node-based data structure where:**
- Each node has at most two children (left and right)
- For every node, all values in the left subtree are less than the node's value
- All values in the right subtree are greater than the node's value
- This property is recursively true for all nodes

**Key Operations:**
- Search: [[O(log n) - Logarithmic time]] average, [[O(n) - Linear time]] worst case
- Insertion: [[O(log n) - Logarithmic time]] average, [[O(n) - Linear time]] worst case
- Deletion: [[O(log n) - Logarithmic time]] average, [[O(n) - Linear time]] worst case

**Traversal Methods:**
- In-order (left, root, right): visits nodes in sorted order
- Pre-order (root, left, right)
- Post-order (left, right, root)

**Time Complexities:**
- Balanced BST: [[O(log n) - Logarithmic time]] for search/insert/delete
- Unbalanced BST: [[O(n) - Linear time]] for these operations


**Example in C#**
```C#
public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    private TreeNode root;

    public void Insert(int value)
    {
        root = InsertRec(root, value);
    }

    private TreeNode InsertRec(TreeNode node, int value)
    {
        if (node == null)
            return new TreeNode(value);

        if (value < node.Value)
            node.Left = InsertRec(node.Left, value);
        else if (value > node.Value)
            node.Right = InsertRec(node.Right, value);

        return node;
    }

    public bool Search(int value)
    {
        return SearchRec(root, value);
    }

    private bool SearchRec(TreeNode node, int value)
    {
        if (node == null)
            return false;

        if (value == node.Value)
            return true;

        if (value < node.Value)
            return SearchRec(node.Left, value);
        else
            return SearchRec(node.Right, value);
    }
}
```