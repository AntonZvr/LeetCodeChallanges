public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // Start with the first word as the initial prefix
        string prefix = strs[0];

        // Compare the prefix with each subsequent string
        for (int i = 1; i < strs.Length; i++)
        {
            // Shrink the prefix until the current word starts with it
            while (strs[i].IndexOf(prefix) != 0)
            {
                // Remove the last character from the prefix
                prefix = prefix.Substring(0, prefix.Length - 1);

                // If the prefix becomes empty, there is no common prefix
                if (prefix.Length == 0)
                {
                    return "";
                }
            }
        }

        return prefix;
    }
}
