**Hash Table - Data Structures and Algorithm Tutorials in Python #5:** https://youtu.be/ea8BRGxGmlA?si=3TdFiIuhjtiIp58c

https://youtu.be/r51TRDECIw4?t=366
https://youtu.be/O9v10jQkm5c?t=652

![[HashMapNames.png]]
- Stores data as key, value pairs
- Key is run through [[Hash Function]] that determines where its value should be stored

**Here's how hashmaps work:**
1. [[Hash Function]]: Takes a key and computes an index (hash code) in an underlying array
2. Storage: Values are stored at computed indices
3. Collision Handling: When different keys hash to the same index, techniques like chaining ([[List (Linked List)]]) or open addressing are used

**Key Properties:**
- Fast lookups
- Dynamic sizing
- Unordered (in most implementations)
- Key uniqueness

**Time Complexities:**
- Average case: [[O(1) - Constant time]] for search, insert, and delete
- Hash Collision - Worst case: [[O(n) - Linear time]] when many collisions occur

**A hash table in RAM typically consists of:**
1. [[Array]] Structure: A contiguous block of memory slots (buckets) where each slot can hold:
	 - An element (key-value pair)
	 - A pointer to a linked list (when using chaining for collision resolution)
	 - Metadata about the slot's state
2. Memory Layout:
	- 0 -> [key1, value1] or pointer to linked list
	- 1 -> [key2, value2] or pointer to linked list
	- 2-> [key3, value3] or pointer to linked list
		...
	- [n-1] -> [keyN, valueN] or pointer to linked list

3. [[Hash Function]]: Applied at runtime to compute array indices from keys
4. Collision Handling:
	 - Chaining: Each bucket contains a pointer to a linked list of elements
	 - Open Addressing: Elements are stored directly in the array using probe sequences

The actual physical memory addresses depend on the programming language's runtime and implementation details, but conceptually it's a combination of:

- An [[Array]] of buckets
- [[Hash Function]] logic
- Collision resolution mechanisms

**Hash Collision Resolution Methods:**

1. Chaining: Each hash table slot contains a linked list or bucket of elements that hash to the same index. When collisions occur, new elements are simply added to the list at that index.
2. Open Addressing: When a collision occurs, the algorithm probes for the next available slot in the hash table using various strategies:
	1. Linear Probing: Check the next slot (i + 1, i + 2, ...)
	2. Quadratic Probing: Check slots using a quadratic function (i + 1², i + 2², ...)
	3. Double Hashing: Use a second [[Hash Function]] to determine the step size
3. Robin Hood Hashing: A variant of open addressing that tries to keep the probe sequence length as uniform as possible by swapping elements when inserting.

These techniques ensure that even when multiple keys hash to the same index, all values can still be stored and retrieved correctly.

**Examples in C#**
The Dictionary class in C# uses a hash table internally, providing [[O(1) - Constant time]] average time complexity for lookups, insertions, and deletions.

In C#, hashmaps are implemented using the Dictionary<TKey, TValue> class. Here's how they're typically used:

```C#
// Creating a dictionary
Dictionary<string, int> ages = new Dictionary<string, int>();

// Adding key-value pairs
ages["Alice"] = 30;
ages["Bob"] = 25;

// Accessing values
int aliceAge = ages["Alice"];

// Checking if key exists
if (ages.ContainsKey("Charlie"))
{
    // Do something
}

// Iterating through the dictionary
foreach (var kvp in ages)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}
```