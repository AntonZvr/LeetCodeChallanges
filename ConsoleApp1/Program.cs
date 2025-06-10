public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length <= 1)
            return intervals;

        // Sort intervals by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        int[] current = intervals[0];

        foreach (var interval in intervals)
        {
            // If intervals overlap, merge them
            if (interval[0] <= current[1])
            {
                current[1] = Math.Max(current[1], interval[1]);
            }
            else
            {
                merged.Add(current);
                current = interval;
            }
        }

        // Add the last interval
        merged.Add(current);

        return merged.ToArray();
    }
}
