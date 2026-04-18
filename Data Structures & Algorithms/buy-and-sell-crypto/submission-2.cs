public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;

        for(int i = 0; i < prices.Length; ++i){
            var price = prices[i];
            for(int j = i + 1; j < prices.Length; ++j){
                res = Math.Max(res,  prices[j] - price);
            }
        }

        return res;
    }
}
