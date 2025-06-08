public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        if (string.IsNullOrEmpty(haystack))
        {
            return -1;
        }

        return haystack.IndexOf(needle);
    }
}