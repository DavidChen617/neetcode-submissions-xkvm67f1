public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0)
            return 0;

        if(nums.Length == 1)
            return nums[0];
        
        return Math.Max(Helper(nums[1..]), Helper(nums[..^1]));

        int Helper(int[] ns){
            int n = ns.Length;
            
            if(n == 0)
                return 0;

            if(n == 1)
                return ns[0];
            
            var dp = new int[n];
            dp[0] = ns[0];
            dp[1] = Math.Max(ns[1], ns[0]);

            for(int i = 2; i < n; ++i)
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + ns[i]);
            
            return dp[n - 1];
        }
    }
}
