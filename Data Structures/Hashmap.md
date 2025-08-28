- Stores data as key, value pairs
- Key is run through hash function that determines where its value should be stored

Here's how hashmaps work:
1. Hash Function: Takes a key and computes an index (hash code) in an underlying array
2. Storage: Values are stored at computed indices
3. Collision Handling: When different keys hash to the same index, techniques like chaining (linked lists) or open addressing are used

**Key Properties:**

• Fast lookups
• Dynamic sizing
• Unordered (in most implementations)
• Key uniqueness

**Time Complexities:**

• Average case: [[O(1) - Constant time]] for search, insert, and delete
• Hash Collision - Worst case: [[O(n) - Linear time]] when many collisions occur

**Hash Collision Resolution Methods:**

1. Chaining: Each hash table slot contains a linked list or bucket of elements that hash to the same index. When collisions occur, new elements are simply added to the list at that index.
2. Open Addressing: When a collision occurs, the algorithm probes for the next available slot in the hash table using various strategies:
	1. Linear Probing: Check the next slot (i + 1, i + 2, ...)
	2. Quadratic Probing: Check slots using a quadratic function (i + 1², i + 2², ...)
	3. Double Hashing: Use a second hash function to determine the step size
3. Robin Hood Hashing: A variant of open addressing that tries to keep the probe sequence length as uniform as possible by swapping elements when inserting.

These techniques ensure that even when multiple keys hash to the same index, all values can still be stored and retrieved correctly.

**Examples in C#**

The Dictionary class in C# uses a hash table internally, providing O(1) average time complexity for lookups, insertions, and deletions.

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