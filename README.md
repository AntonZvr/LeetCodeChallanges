Problem Description
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once. For example, "eat", "tea", and "ate" are anagrams of each other because they all consist of the same letters ('a', 'e', 't') with the same frequencies.

Examples
Example 1:

strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Explanation:
"bat" is a group by itself.
"nat" and "tan" are anagrams.
"ate", "eat", and "tea" are anagrams.
The order of groups and strings within groups doesn't matter.
