public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        // Split the input string into words
        string[] words = s.Split(' ');

        // If lengths don't match, pattern can't be valid
        if (words.Length != pattern.Length)
        {
            return false;
        }

        // Map from pattern character to word
        Dictionary<char, string> charToStringMap = new Dictionary<char, string>();
        // Map from word to pattern character
        Dictionary<string, char> stringToCharMap = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            char currentChar = pattern[i];
            string currentWord = words[i];

            // Check or establish char → word mapping
            if (charToStringMap.ContainsKey(currentChar))
            {
                // If current mapping doesn't match, pattern fails
                if (charToStringMap[currentChar] != currentWord)
                {
                    return false;
                }
            }
            else
            {
                charToStringMap.Add(currentChar, currentWord);
            }

            // Check or establish word → char mapping
            if (stringToCharMap.ContainsKey(currentWord))
            {
                // If word already mapped to different char, fail
                if (stringToCharMap[currentWord] != currentChar)
                {
                    return false;
                }
            }
            else
            {
                stringToCharMap.Add(currentWord, currentChar);
            }
        }

        return true;
    }
}
