public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var cache = new Dictionary<int, int>();
        var res = DFS(amount);
    
        return res >= (int)1e9 ? -1 : res;

        int DFS(int amt){
            if(amt == 0)
                return 0;

            if(cache.TryGetValue(amt, out var value))
                return value;

            int res = (int)1e9;

            for(int i = 0; i < coins.Length; ++i){
                var coin = coins[i];
                var money = amt - coin;

                if(money >= 0)
                    res = Math.Min(res, DFS(money) + 1);
            }

            cache.Add(amt, res);

            return res;
        }
    }
}
