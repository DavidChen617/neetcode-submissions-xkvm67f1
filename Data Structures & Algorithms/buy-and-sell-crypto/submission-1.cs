public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length, 
            l = 0, 
            r = 1,
            res = 0;

        while(r < n){
            if(prices[l] < prices[r])
                res = Math.Max(prices[r] - prices[l], res);
            else
                l = r;
            ++r;
        }

        return res;
    }
}
