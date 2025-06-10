public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Loop through each element
        for (int i = 0; i < nums.Length; i++)
        {
            // For each i, check all elements after it
            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];

                // If a valid pair is found
                if (sum == target)
                {
                    // Find the first index of nums[i] and last index of nums[j]
                    int[] res = {
                        Array.FindIndex(nums, x => x == nums[i]),
                        Array.LastIndexOf(nums, nums[j])
                    };

                    return res;
                }
            }
        }

        // If no pair found, return empty array
        return new int[0];
    }
}
