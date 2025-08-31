**[[Array]]:**
- Fixed size (cannot grow/shrink)
- Contiguous memory allocation
- O(1) random access by index
- O(n) insertion/deletion (requires shifting elements)
- Memory efficient for fixed-size data

**[[ArrayList]]:**
- Dynamic size (grows/shrinks automatically)
- Contiguous memory allocation (like arrays)
- O(1) random access by index
- O(1) amortized insertion at end, O(n) for middle insertions
- More flexible than fixed arrays

**[[Linked List]]:**
- Dynamic size
- Non-contiguous memory (nodes scattered)
- O(n) random access (must traverse from beginning)
- O(1) insertion/deletion at known positions
- Extra memory overhead for pointers/references

**The key differences are:**
1. Size flexibility (ArrayList vs fixed Array)
2. Memory layout (contiguous vs scattered)
3. Access time complexity (O(1) vs O(n))
4. Insertion/deletion efficiency