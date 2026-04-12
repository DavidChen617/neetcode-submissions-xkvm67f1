public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        for(int i = 1; i <= amount; ++i){
            for(int c = 0; c < coins.Length; ++c){
                var coin = coins[c];
                if(coin <= i){
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }
        
        return dp[amount] > amount? -1 : dp[amount];
    }
}
