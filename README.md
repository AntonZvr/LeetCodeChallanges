
Problem Description
Given an array of integers nums, remove the duplicate numbers from it. Using a HashSet implies we are typically interested in:

Counting the number of unique elements.
Populating the original array (from index 0) with these unique elements, potentially changing their order if the original array was unsorted.
Returning the count of unique elements.
The order of the unique elements in the modified nums array is usually not guaranteed to be the same as their first appearance in the original array when using a HashSet, as HashSet itself doesn't preserve insertion order.

Examples
Example 1:

nums = [1, 1, 2]
Output: 2
nums after operation (conceptual): [1, 2, ...] (the ... represent irrelevant values beyond the new length).
Explanation: The unique elements are 1 and 2.
Example 2:

nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
Output: 5
nums after operation (conceptual): [0, 1, 2, 3, 4, ...]
Explanation: The unique elements are 0, 1, 2, 3, and 4.
