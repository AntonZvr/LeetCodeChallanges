public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // Dictionary to group words by their sorted character form
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            // Convert word to char array, sort it, and convert back to string
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            // Use the sorted string as the key
            if (!anagramGroups.ContainsKey(sorted))
            {
                anagramGroups[sorted] = new List<string>();
            }

            // Add the original word to the group
            anagramGroups[sorted].Add(word);
        }

        // Return the groups as a list of lists
        return new List<IList<string>>(anagramGroups.Values);
    }
}
