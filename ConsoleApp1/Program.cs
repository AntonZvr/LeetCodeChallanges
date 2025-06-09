using System.Text;

public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder res = new StringBuilder();
        
        Array.Reverse(words);

        for (int i = 0; i < words.Length; i++) 
        {
            res.Append(words[i]);
            if (i < words.Length - 1)
            {
                res.Append(' ');
            }
        }

        return res.ToString();
    }
}