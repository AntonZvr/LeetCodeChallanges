public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] charArray = x.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new String(charArray) == x.ToString();
    }
}