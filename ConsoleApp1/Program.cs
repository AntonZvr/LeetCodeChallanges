public class Solution
{
    public int MajorityElement(int[] nums)
    {
        // Dictionary to store counts of each number
        Dictionary<int, int> counts = new Dictionary<int, int>();

        int mostFrequentNumber = nums[0];
        int maxCount = 0;

        foreach (int number in nums)
        {
            // Increment count if number already seen, else initialize to 1
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts[number] = 1;
            }

            // Update most frequent number if current count is higher
            if (counts[number] > maxCount)
            {
                maxCount = counts[number];
                mostFrequentNumber = number;
            }
        }

        return mostFrequentNumber;
    }
}
