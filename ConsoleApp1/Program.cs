public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int sIndex = 0;                 
        int lIndex = numbers.Length - 1; 

        // Move pointers inward until they meet
        while (sIndex < lIndex)
        {
            int sum = numbers[sIndex] + numbers[lIndex];

            if (sum == target)
            {
                // Return 1-based indices as per problem statement
                return new int[] { sIndex + 1, lIndex + 1 };
            }
            else if (sum < target)
            {
                // If sum too small, move start pointer right to increase sum
                sIndex++;
            }
            else
            {
                // If sum too large, move end pointer left to decrease sum
                lIndex--;
            }
        }

        return new int[0];
    }
}
