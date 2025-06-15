Problem Description
Given two strings, s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is formed by deleting zero or more characters from the original string t without changing the relative order of the remaining characters.

For example:

"ace" is a subsequence of "abcde". (We deleted 'b' and 'd').
"aec" is NOT a subsequence of "abcde" because the order of 'e' and 'c' is disturbed.
Examples
Example 1:

s = "abc"
t = "ahbgdc"
Output: true
Explanation: 'a' is found, then 'b' (after 'h'), then 'c' (after 'g' and 'd'). The relative order is maintained.
