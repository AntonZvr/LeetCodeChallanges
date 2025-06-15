
Problem Description
Given a pattern string and a s string, find if s follows the same pattern.

Here, "follows" means a full match, such that there is a one-to-one correspondence (a bijection) between a letter in pattern and a non-empty word in s.

This implies two crucial conditions for a valid match:

Each letter in pattern must map to exactly one unique word in s.
Each word in s must map back to exactly one unique letter in pattern.

Example 1:

pattern = "abba"
s = "dog cat cat dog"
Output: true
Explanation: 'a' maps to "dog", 'b' maps to "cat". This mapping is consistent and unique in both directions.
