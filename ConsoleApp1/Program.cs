public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> bracketMap = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char lastOpenedBracket = stack.Pop();

                if (bracketMap[c] != lastOpenedBracket)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}