public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        var result = 0;
        
        while(l < r){
            int hl = heights[l], hr = heights[r];
            result = Math.Max((Math.Min(hl, hr) * (r - l)), result);

            if(hl < hr)
                ++l;
            else
                --r;
        }

        return result;
    }
}
