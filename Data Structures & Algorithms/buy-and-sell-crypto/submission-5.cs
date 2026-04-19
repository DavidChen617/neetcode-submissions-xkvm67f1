public class Solution {
    public int MaxProfit(int[] prices) {
        int maxPrice = 0,
            minBuy = prices[0];

        for(int i = 0; i < prices.Length; ++i){
            maxPrice = Math.Max(maxPrice, prices[i] - minBuy);
            minBuy = Math.Min(minBuy, prices[i]);
        }

        return maxPrice;
    }
}
