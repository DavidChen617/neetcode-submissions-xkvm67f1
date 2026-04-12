public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var len = nums.Length;
        int[] ans = new int[len * 2];
        int s = 0;
        
        for(var i = 0; i < 2; ++i){
            for(var j = 0; j < len; ++j){
                ans[s] = nums[j];
                ++s;
            }
        }
    
        return ans;
    }
}