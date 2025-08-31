A priority queue is an abstract data type that operates like a regular [[Queue]] or [[Stack]], but with priorities assignedto each element.

Key operations:

• Insert(element, priority): Add an element with specified priority
• ExtractMin/ExtractMax(): Remove and return element with highest (or lowest) priority

Priority queues are commonly implemented using binary [[Heap]]s, which provide [[O(log n) - Logarithmic time]] time complexity for insert and extract operations.

In [[Dijkstra's]] algorithm, a priority queue is used to efficiently select the next vertex with the minimum distance from the source.

--- 
 A [[Heap]] is a common implementation of a priority queue.

Heaps provide the efficient operations needed for priority queues:

• Insertion: [[O(log n) - Logarithmic time]]
• Extraction of minimum/maximum: [[O(log n) - Logarithmic time]]

Binary heaps are the most popular implementation because they offer good performance characteristics and can be efficiently stored in [[Array]]s.