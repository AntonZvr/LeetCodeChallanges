public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        return words[0].Length;
    }
}
