public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];
                if (sum == target)
                {
                    int[] res = { Array.FindIndex(nums, x => x == nums[i]), Array.LastIndexOf(nums, nums[j]) };
                    return res;
                }
            }
        }
        return new int[0];
    }
}
