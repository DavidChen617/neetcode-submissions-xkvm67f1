public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var n = cost.Length;
        var dp = new int[n+1]; // the end point in boundary
        // [1, 2, 3]
        /**
            i = 2
            dp[2] = dp[1] + cost[1] (0 + 2) // one
            dp[2] = dp[0] + cost[0] (0 + 1) // two
            dp[2] = 1
            i = 3
            dp[3] = dp[2] + cost[2] (1 + 3) // one
            dp[3] = dp[1] + cost[1] (0 + 2) // two
            dp[3] = 2
        */
        for(int i = 2; i <= n; ++i){
            int one = i-1, two = i-2;
            int payOneStep = dp[one] + cost[one],
            payTwoStep = dp[two] + cost[two];

            dp[i] = Math.Min(payOneStep, payTwoStep);
        }

        return dp[n];
    }
}
