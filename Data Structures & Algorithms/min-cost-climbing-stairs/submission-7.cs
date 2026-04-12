public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        var dp = new int[n + 1];

        for(int i = 2; i <= n; ++i){    
            var takeOneStep = dp[i - 1] + cost[i - 1];
            var takeTwoStep = dp[i - 2] + cost[i - 2];
            dp[i] = Math.Min(takeOneStep, takeTwoStep);
        }
            
        return dp[n];
    }
}
