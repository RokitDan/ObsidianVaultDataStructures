**A specific kind of mathematical algorithm that:**
1. Takes an input (or 'message') of any length
2. Produces a fixed-length output (hash code or hash value)
3. Is deterministic (same input always produces same output)
4. Is typically one-way (difficult to reverse-engineer the input from the output)
5. Has the property of 'avalanche effect' (small changes in input produce significantly different outputs)

Hash functions are fundamental to [[Hashmap]], cryptographic applications, data integrity checks, and many other computer science concepts.

**A simple hash function in C# could look like this:**
```C#
 public static int SimpleHash(string key)
{
    int hash = 0;
    foreach (char c in key)
    {
        hash = hash * 31 + c;
    }
    return Math.Abs(hash);
}
```

**This is a basic example that:**
1. Takes a string key as input
2. Processes each character using multiplication and addition
3. Applies the modulo operation implicitly through integer overflow
4. Returns a positive integer hash code

In C#, the built-in GetHashCode() method on objects implements hash functions for various types, and collections like Dictionary<TKey, TValue> and HashSet<T> use these hash functions internally to determine storage locations.


