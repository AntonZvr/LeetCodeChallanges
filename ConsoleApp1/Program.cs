public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int sIndex = 0;
        int lIndex = numbers.Length - 1;


        while (sIndex < lIndex)
        {
            int sum = numbers[sIndex] + numbers[lIndex];

            if (sum == target)
            {
                return new int[] { sIndex + 1, lIndex + 1 };
            }
            else if (sum < target)
            {
                sIndex++;
            }
            else
            {
                lIndex--;
            }
        }
        return new int[0];
    }
}