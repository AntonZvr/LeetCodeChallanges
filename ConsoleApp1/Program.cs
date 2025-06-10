public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, char> mapST = new Dictionary<char, char>();
        HashSet<char> mappedChars = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (mapST.ContainsKey(c1))
            {
                if (mapST[c1] != c2)
                    return false;
            }
            else
            {
                if (mappedChars.Contains(c2))
                    return false;

                mapST[c1] = c2;
                mappedChars.Add(c2);
            }
        }

        return true;
    }
}
