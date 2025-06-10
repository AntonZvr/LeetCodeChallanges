using System.Text;

public class Solution
{
    public static int RomanToInt(string s)
    {
        // Map of Roman numerals to integer values
        Dictionary<char, int> romanToIntPairs = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int res = 0;
        int n = s.Length;

        // Loop through the string, stopping at the second-to-last character
        for (int i = 0; i < n - 1; i++)
        {
            char currentChar = s[i];
            char nextChar = s[i + 1];

            int currentValue = romanToIntPairs[currentChar];
            int nextValue = romanToIntPairs[nextChar];

            // If the current value is less than the next, it's a subtractive pair
            if (currentValue < nextValue)
            {
                res -= currentValue;
            }
            else
            {
                res += currentValue;
            }
        }

        // Add the value of the last character
        res += romanToIntPairs[s[n - 1]];

        return res;
    }
}
