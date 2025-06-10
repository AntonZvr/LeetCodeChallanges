public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        // Map from char in s to char in t
        Dictionary<char, char> mapST = new Dictionary<char, char>();
        // Keep track of chars in t already mapped to prevent duplicates
        HashSet<char> mappedChars = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            // If c1 already mapped, check consistency
            if (mapST.ContainsKey(c1))
            {
                if (mapST[c1] != c2)
                    return false;
            }
            else
            {
                // If c2 already mapped to a different char, return false
                if (mappedChars.Contains(c2))
                    return false;

                // Add mapping c1 -> c2 and mark c2 as used
                mapST[c1] = c2;
                mappedChars.Add(c2);
            }
        }

        return true;
    }
}
