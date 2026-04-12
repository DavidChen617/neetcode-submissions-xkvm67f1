public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length,
            res = 0;

        for(int i = 0; i < n; ++i){
            for(int j = i + 1; j < n; ++j){
              var val = (j - i) * Math.Min(heights[i], heights[j]);
              res = Math.Max(res, val);
            }
        }

        return res;
    }
}
