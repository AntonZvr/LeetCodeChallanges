public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');

        if (words.Length != pattern.Length)
        {
            return false;
        }

        Dictionary<char, string> charToStringMap = new Dictionary<char, string>();
        Dictionary<string, char> stringToCharMap = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            char currentChar = pattern[i];
            string currentWord = words[i];

            if (charToStringMap.ContainsKey(currentChar))
            {
                if (charToStringMap[currentChar] != currentWord)
                {
                    return false;
                }
            }
            else
            {
                charToStringMap.Add(currentChar, currentWord);
            }

            if (stringToCharMap.ContainsKey(currentWord))
            {
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