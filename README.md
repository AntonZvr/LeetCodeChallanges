Problem Description
Given two strings, s and t, determine if they are isomorphic.

Two strings s and t are considered isomorphic if the characters in s can be replaced to get t. The rules for replacement are strict:

Preserve Order: All occurrences of a character in s must be replaced with the same character in t, while preserving the original order of characters.
Unique Mapping (Bijection): No two distinct characters in s may map to the same character in t. However, a character may map to itself. This implies a bi-directional unique mapping: if s_char maps to t_char, then t_char must only map back to s_char.
Essentially, if you were to transform s into t character by character, you'd need a consistent and unique substitution rule for every character.

Examples
Let's clarify what "isomorphic" means with some scenarios:

Example 1:

s = "egg"
t = "add"
Output: true
Explanation:
'e' maps to 'a'
'g' maps to 'd'
This mapping is consistent (e always a, g always d) and unique (no other char maps to a or d, and vice versa).
