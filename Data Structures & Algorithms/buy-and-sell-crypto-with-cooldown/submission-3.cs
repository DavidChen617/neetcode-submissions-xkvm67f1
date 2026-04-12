public class Solution {
    public int MaxProfit(int[] prices) {
        var memo = new Dictionary<(int day, bool buying), int>();

        return DFS(0, true);

        int DFS(int i, bool buying)
        {
            if (i >= prices.Length)
                return 0;

            var key = (i, b: buying);
            if (memo.TryGetValue(key, out var value))
                return value;

            int cooldown = DFS(i + 1, buying);

            if (buying)
            {
                int buy = DFS(i + 1, !buying) - prices[i];
                memo.Add(key, Math.Max(buy, cooldown));
            }
            else
            {
                int sell = DFS(i + 2, !buying) + prices[i];
                memo.Add(key, Math.Max(sell, cooldown));
            }
            
            return memo[key];
        }
    }
}
