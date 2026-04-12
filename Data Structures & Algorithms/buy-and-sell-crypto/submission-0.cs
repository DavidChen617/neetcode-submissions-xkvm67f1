public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length,
            res = 0;

        for(int i = 0; i < n; ++i){
            for(int j = i + 1; j < n; ++j){
                res = Math.Max(prices[j] - prices[i], res);
            }
        }

        return res;
    }
}
