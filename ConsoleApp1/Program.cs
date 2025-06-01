using System.Text;

public class Solution
{
    public static int RomanToInt(string s)
    {
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

        for (int i = 0; i < n - 1; i++)
        {
            char currentChar = s[i];
            char nextChar = s[i + 1];

            int currentValue = romanToIntPairs[currentChar];
            int nextValue = romanToIntPairs[nextChar];

            if (currentValue < nextValue)
            {
                res -= currentValue;
            }
            else
            {
                res += currentValue;
            }
        }

        res += romanToIntPairs[s[n - 1]];

        return res;
    }
}
