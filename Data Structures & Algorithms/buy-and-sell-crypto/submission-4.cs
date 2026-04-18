public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0,
            minBuy = prices[0];

        for(int i = 1; i < prices.Length; ++i){
            maxP = Math.Max(maxP, prices[i] - minBuy);
            minBuy = Math.Min(minBuy, prices[i]);
        }

        return maxP;
    }
}
