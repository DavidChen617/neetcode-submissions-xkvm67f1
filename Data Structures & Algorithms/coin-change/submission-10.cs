public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        for(int amt = 1; amt <= amount; ++amt){
            for(int c = 0; c < coins.Length; ++c){
                var coin = coins[c];
                if(coin <= amt){
                    dp[amt] = Math.Min(dp[amt], dp[amt - coin] + 1);
                }
            }
        }
        
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
