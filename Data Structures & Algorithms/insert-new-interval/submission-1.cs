public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var result = new List<int[]>();

        for(int i = 0; i < intervals.Length; ++i){
            var interval = intervals[i];
            
            if(newInterval[1] < interval[0]){
                result.Add(newInterval);
                result.AddRange(intervals.Skip(i));

                return result.ToArray();
            }
            else if(newInterval[0] > interval[1]){
                result.Add(interval);
            }
            else{
                newInterval[0] = Math.Min(newInterval[0], interval[0]);
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
        }

        result.Add(newInterval);
        return result.ToArray();
    }
}
