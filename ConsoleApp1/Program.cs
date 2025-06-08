public class Solution
{
    public int RemoveDuplicatesUsingHashSet(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> seen = new HashSet<int>();
        int k = 0;

        foreach (int num in nums)
        {
            if (seen.Add(num))
            {
                nums[k] = num;
                k++;
            }
        }

        return k;
    }
}