public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var len = nums.Length;
        int[] ans = new int[len * 2];
        
        for(var i = 0; i < len; ++i){
            ans[i] = nums[i];
            ans[len + i] = nums[i];
        }
    
        return ans;
    }
}