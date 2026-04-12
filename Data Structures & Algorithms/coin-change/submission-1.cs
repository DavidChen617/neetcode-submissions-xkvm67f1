public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var cache = new Dictionary<int, int>();
        var result = DFS(amount);

        return result >= (int)1e9? -1 : result;

        int DFS(int amt){
            if(amt == 0)
                return 0;

            if(cache.TryGetValue(amt, out var value))
                return value;

            int res = (int)1e9;

            foreach(var coin in coins){
                if(amt - coin >= 0){
                    res = Math.Min(
                            res,
                            1 + DFS(amt - coin)
                    );
                }
            }
            cache[amt] = res;

            return res;
        }
    }
}
