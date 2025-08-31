using System;
using System.Collections.Generic;
using System.Linq;

public class Dijkstra
{
    // Graph representation using adjacency list
    private Dictionary<int, List<(int node, int weight)>> graph;
    
    public Dijkstra()
    {
        graph = new Dictionary<int, List<(int node, int weight)>>();
    }
    
    // Add edge to the graph
    public void AddEdge(int from, int to, int weight)
    {
        if (!graph.ContainsKey(from))
            graph[from] = new List<(int node, int weight)>();
            
        if (!graph.ContainsKey(to))
            graph[to] = new List<(int node, int weight)>();
            
        graph[from].Add((to, weight));
    }
    
    // Dijkstra's algorithm with binary heap optimization
    public Dictionary<int, int> FindShortestPaths(int source)
    {
        // Distance dictionary to store shortest distances
        var distances = new Dictionary<int, int>();
        
        // Previous node dictionary for path reconstruction
        var previous = new Dictionary<int, int>();
        
        // Priority queue implemented with binary heap
        var pq = new BinaryHeap<(int node, int distance)>(Comparer<(int node, int distance)>.Create((x, y) => x.distance.CompareTo(y.distance)));
        
        // Initialize distances
        foreach (var node in graph.Keys)
        {
            distances[node] = node == source ? 0 : int.MaxValue;
            previous[node] = -1;
        }
        
        // Add source to priority queue
        pq.Enqueue((source, 0));
        
        while (pq.Count > 0)
        {
            // Get node with minimum distance
            var current = pq.Dequeue();
            int currentNode = current.node;
            
            // Skip if we've already found a shorter path
            if (distances[currentNode] < current.distance)
                continue;
                
            // Explore neighbors
            if (graph.ContainsKey(currentNode))
            {
                foreach (var edge in graph[currentNode])
                {
                    int neighbor = edge.node;
                    int weight = edge.weight;
                    
                    // Calculate new distance
                    int newDistance = distances[currentNode] + weight;
                    
                    // If we found a shorter path, update it
                    if (newDistance < distances[neighbor])
                    {
                        distances[neighbor] = newDistance;
                        previous[neighbor] = currentNode;
                        
                        // Add to priority queue
                        pq.Enqueue((neighbor, newDistance));
                    }
                }
            }
        }
        
        return distances;
    }
    
    // Binary heap implementation for priority queue
    public class BinaryHeap<T>
    {
        private List<T> items;
        private IComparer<T> comparer;
        
        public BinaryHeap(IComparer<T> comparer)
        {
            this.comparer = comparer;
            items = new List<T>();
        }
        
        public int Count => items.Count;
        
        public void Enqueue(T item)
        {
            items.Add(item);
            HeapifyUp(items.Count - 1);
        }
        
        public T Dequeue()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Heap is empty");
                
            T result = items[0];
            
            // Move last element to root
            items[0] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            
            if (items.Count > 0)
                HeapifyDown(0);
                
            return result;
        }
        
        private void HeapifyUp(int index)
        {
            if (index == 0) return;
            
            int parentIndex = (index - 1) / 2;
            
            if (comparer.Compare(items[index], items[parentIndex]) < 0)
            {
                Swap(index, parentIndex);
                HeapifyUp(parentIndex);
            }
        }
        
        private void HeapifyDown(int index)
        {
            int smallest = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            
            if (leftChild < items.Count && 
                comparer.Compare(items[leftChild], items[smallest]) < 0)
            {
                smallest = leftChild;
            }
            
            if (rightChild < items.Count && 
                comparer.Compare(items[rightChild], items[smallest]) < 0)
            {
                smallest = rightChild;
            }
            
            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }
        
        private void Swap(int i, int j)
        {
            T temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }
}