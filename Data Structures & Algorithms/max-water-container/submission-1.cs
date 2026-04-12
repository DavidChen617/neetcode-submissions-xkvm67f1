public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0,
            l = 0,
            r = heights.Length-1;
        
        while(l < r){
            int lh = heights[l], 
                rh = heights[r];

            var area = (r - l) * Math.Min(lh, rh);
            res = Math.Max(res, area);

            if(lh < rh)
                ++l;
            else
                --r;
        }

        return res;
    }
}
