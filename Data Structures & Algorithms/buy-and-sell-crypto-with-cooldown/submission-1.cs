public class Solution {
    public int MaxProfit(int[] prices) {
        var memo = new Dictionary<(int, bool), int>();
        return DFS(0, true);

        int DFS(int i, bool buying){
            if(i >= prices.Length)
                return 0;

            if(memo.TryGetValue((i, buying), out var value))
                return value;

            int cooldwon = DFS(i + 1, buying);
            
            if(buying){
                int buy = DFS(i + 1, false) - prices[i];
                memo.Add((i, buying), Math.Max(buy, cooldwon));
            }
            else{
                int sell = DFS(i + 2, true) + prices[i];
                memo.Add((i, buying), Math.Max(sell, cooldwon));
            }

            return memo[(i, buying)];
        }
    }
}
