/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        intervals.Sort((a, b) => a.start.CompareTo(b.start));
        var minQueue = new PriorityQueue<int, int>();

        for (int i = 0; i < intervals.Count; i++)
        {
            if (minQueue.Count > 0 && minQueue.Peek() <= intervals[i].start)
                minQueue.Dequeue();
            minQueue.Enqueue(intervals[i].end, intervals[i].end);
        }
        
        return minQueue.Count;
    }
}
