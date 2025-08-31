Dijkstra's algorithm is a [[Graph]] search algorithm that finds the shortest paths from a source vertex to all other vertices in a weighted graph with non-negative edge weights.

**Key characteristics:**
- Finds shortest path tree from source
- Uses greedy approach with priority selection
- Time complexity: O(V²) for basic implementation, O((V + E) log V) with binary heaps
- Space complexity: O(V)
- Works only with non-negative edge weights

**Algorithm steps:**
1. Initialize distances to infinity except source (0)
2. Use priority queue to select vertex with minimum distance
3. For selected vertex, update distances to neighbors
4. Repeat until all vertices processed

It's widely used in routing protocols and GPS navigation systems.

*Example in C#*


```C#
using System;
using System.Collections.Generic;

public class DijkstraExample
{
    private Dictionary<int, List<(int vertex, int weight)>> adjacencyList;

    public DijkstraExample()
    {
        adjacencyList = new Dictionary<int, List<(int vertex, int weight)>>();
    }

    public void AddEdge(int source, int destination, int weight)
    {
        if (!adjacencyList.ContainsKey(source))
            adjacencyList[source] = new List<(int vertex, int weight)>();

        if (!adjacencyList.ContainsKey(destination))
            adjacencyList[destination] = new List<(int vertex, int weight)>();

        adjacencyList[source].Add((destination, weight));
    }

    public Dictionary<int, int> FindShortestPaths(int source)
    {
        var distances = new Dictionary<int, int>();
        var previous = new Dictionary<int, int>();
        var visited = new HashSet<int>();

        // Initialize all distances to infinity
        foreach (var vertex in adjacencyList.Keys)
        {
            distances[vertex] = int.MaxValue;
            previous[vertex] = -1;
        }

        // Distance to source is 0
        distances[source] = 0;

        // Create binary heap for priority queue
        var minHeap = new BinaryHeap<int, int>();
        minHeap.Insert(source, 0);

        while (minHeap.Count > 0)
        {
            // Extract vertex with minimum distance
            var currentVertex = minHeap.ExtractMin();
            int currentDistance = currentVertex.Value;

            if (visited.Contains(currentVertex.Key))
                continue;

            visited.Add(currentVertex.Key);

            // Check neighbors
            if (adjacencyList.ContainsKey(currentVertex.Key))
            {
			                foreach (var (neighbor, weight) in adjacencyList[currentVertex.Key])
                {
                    if (!visited.Contains(neighbor))
                    {
                        int newDistance = currentDistance + weight;

                        // If we found a shorter path
                        if (newDistance < distances[neighbor])
                        {
                            distances[neighbor] = newDistance;
                            previous[neighbor] = currentVertex.Key;

                            // Update the heap
                            minHeap.Insert(neighbor, newDistance);
                        }
                    }
                }
            }
        }

        return distances;
    }
}

public class BinaryHeap<TKey, TValue> where TKey : IComparable<TKey>
{
    private List<(TKey key, TValue value)> heap;

    public BinaryHeap()
    {
        heap = new List<(TKey key, TValue value)>();
    }

    public int Count => heap.Count;

    public void Insert(TKey key, TValue value)
    {
        heap.Add((key, value));
        HeapifyUp(heap.Count - 1);
    }

    public (TKey key, TValue value) ExtractMin()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        var min = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        if (heap.Count > 0)
            HeapifyDown(0);

        return min;
    }

    private void HeapifyUp(int index)
    {
        if (index == 0) return;

        int parentIndex = (index - 1) / 2;

        if (heap[parentIndex].value.CompareTo(heap[index].value) > 0)
        {
            Swap(parentIndex, index);
            HeapifyUp(parentIndex);
        }
    }

    private void HeapifyDown(int index)
    {
        int leftChildIndex = 2 * index + 1;
        int rightChildIndex = 2 * index + 2;
        int smallestIndex = index;

        if (leftChildIndex < heap.Count &&
            heap[leftChildIndex].value.CompareTo(heap[smallestIndex].value) < 0)
        {
            smallestIndex = leftChildIndex;
        }

        if (rightChildIndex < heap.Count &&
            heap[rightChildIndex].value.CompareTo(heap[smallestIndex].value) < 0)
        {
            smallestIndex = rightChildIndex;
        }

        if (smallestIndex != index)
        {
            Swap(index, smallestIndex);
            HeapifyDown(smallestIndex);
        }
    }

    private void Swap(int i, int j)
    {
        var temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}
```

This implementation:

1. Uses an adjacency list to represent the graph
2. Implements a binary heap as a priority queue for efficient extraction of minimum distances
3. Finds shortest paths from a source vertex to all other vertices
4. Has O((V + E) log V) time complexity where V is vertices and E is edges
5. Uses O(V) space complexity

The binary heap optimization improves performance over the basic O(V²) implementation, especially for sparse graphs.