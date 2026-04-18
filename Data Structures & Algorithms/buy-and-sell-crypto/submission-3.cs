public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int res = 0;

        for(int r = 1; r < prices.Length; ++r){
            if(prices[r] > prices[l])
                res = Math.Max(prices[r] - prices[l], res);
            else
                l = r;
        }

        return res;  
    }
}
