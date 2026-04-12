public class Solution {
    public int Rob(int[] nums) {
        if(!nums.Any())
            return 0;

        if(nums.Length == 1)
            return nums[0];

        var dp = new int[]{0, 0};

        foreach(var n in nums){
            var t = dp[0];
            dp[0] = Math.Max(dp[0], dp[1] + n);
            dp[1] = t;
        }

        return dp[0];
    }
}
