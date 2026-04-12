public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length * 2;
        var ans = new int[len];
        for(int i = 0; i < nums.Length; ++i){
            ans[i] = nums[i];
            ans[nums.Length + i] = nums[i];
        }

        return ans;
    }
}