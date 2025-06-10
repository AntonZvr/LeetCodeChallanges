public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        // Map closing brackets to their corresponding opening brackets
        Dictionary<char, char> bracketMap = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s)
        {
            // If it's an opening bracket, push to stack
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            // If it's a closing bracket
            else if (c == ')' || c == '}' || c == ']')
            {
                // If stack is empty, there's no opening match
                if (stack.Count == 0)
                {
                    return false;
                }

                // Pop the last opening bracket
                char lastOpenedBracket = stack.Pop();

                // Check if it matches the current closing bracket
                if (bracketMap[c] != lastOpenedBracket)
                {
                    return false;
                }
            }
        }

        // Valid if no unmatched opening brackets remain
        return stack.Count == 0;
    }
}
