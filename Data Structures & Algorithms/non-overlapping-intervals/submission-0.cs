public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int lastEnd = intervals[0][1], count = 0;

        for (int i = 1; i < intervals.Length; i++)
        {
            int start = intervals[i][0], end = intervals[i][1];
            if (start < lastEnd)
                count++;
            else
                lastEnd = end;
        }

        return count;
    }
}
