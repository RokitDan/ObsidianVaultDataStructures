LINQ (Language Integrated Query) is a powerful feature in C# that
provides integrated query capabilities directly within the
language. It allows you to write queries against various data
sources using a consistent syntax.

## Key LINQ Functions

LINQ functions can be broadly categorized into:
1. Selection Operations - Used to extract elements from collections:
	- Select - Projects each element into a new form
	- Where - Filters elements based on a condition
2. Aggregation Operations - Perform calculations on collections:
	- Count - Gets the number of elements
	- Sum, Average, Min, Max - Mathematical operations
3. Sorting Operations - Arrange elements in a specific order:
	- OrderBy, OrderByDescending - Sort by a key
	- ThenBy, ThenByDescending - Secondary sorting
4. Grouping Operations - Organize elements into groups:
	- GroupBy - Groups elements by a key
5. Join Operations - Combine data from multiple sources:
	- Join - Joins two sequences based on matching keys

## Relationship to Data Structures

LINQ works with various data structures in C#:

1. [[Array]]s and Lists - The most common collections for LINQ operations
2. [[Hashmap]] or Dictionary - LINQ can query dictionary keys and values
3. Collections - Any collection implementing [[IEnumerable]] can use LINQ

In ASP.NET, LINQ is particularly useful for:

• Querying data from databases using Entity Framework
• Processing and transforming collections in controllers or
services
• Filtering and sorting data before returning to the client
