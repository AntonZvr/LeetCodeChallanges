public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int mostFrequentNumber = nums[0];
        int maxCount = 0;

        foreach (int number in nums)
        {
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts[number] = 1;
            }

            if (counts[number] > maxCount)
            {
                maxCount = counts[number];
                mostFrequentNumber = number;
            }
        }
        return mostFrequentNumber;
    }
}