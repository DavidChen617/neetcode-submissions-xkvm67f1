public class Solution {
    public int Rob(int[] nums) {
        var n = nums.Length;

        if(n == 0)
            return 0;
        
        if(n == 1)
            return nums[0];
        
        var fromFirstAndSkipLast = Helper(nums[..^1]);
        var fromScondToLast = Helper(nums[1..]);

        return Math.Max(fromFirstAndSkipLast, fromScondToLast);

        int Helper(int[] ns){
            var nl = ns.Length;
            
            if(nl == 0)
                return 0;
        
            if(nl == 1)
                return ns[0];

            var dp = new int[nl];
            dp[0] = ns[0];
            dp[1] = Math.Max(ns[0], ns[1]);

            for(int i = 2; i < nl; ++i){
                dp[i] = Math.Max(dp[i-1], ns[i] + dp[i-2]);
            }

            return dp[nl-1];
        }
    }
}
