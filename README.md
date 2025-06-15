Problem Description
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
Examples
Let's illustrate with a few scenarios:

Example 1:

s = "()"
Output: true
Explanation: The parentheses are opened and closed correctly.
Example 2:

s = "()[]{}"
Output: true
Explanation: All types of brackets are opened and closed correctly and in order.
Example 3:

s = "(]"
Output: false
Explanation: An opening parenthesis is incorrectly closed by a square bracket.
Example 4:

s = "([)]"
Output: false
Explanation: The square bracket is opened, then a parenthesis, then the parenthesis is closed (correctly), but then the square bracket is closed before the inner parenthesis was, violating the "correct order" rule.
