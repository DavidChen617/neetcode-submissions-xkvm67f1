public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var result = new List<int[]>();
        result.Add(intervals[0]);

        for (int i = 0; i < intervals.Length; i++)
        {
            var interval = intervals[i];
            int start = interval[0],
                end = interval[1],
                lastEnd = result[result.Count - 1][1];

            if (start <= lastEnd)
            {
                result[result.Count - 1][1] = Math.Max(end, lastEnd);
            }
            else
            {
                result.Add(interval);
            }
        }

        return result.ToArray();

    }
}
