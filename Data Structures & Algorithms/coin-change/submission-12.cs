public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var cache = new Dictionary<int, int>();
        var res = DFS(amount);

        return res >= (int)1e9 ? -1 : res;

        int DFS(int target){
            if(target == 0)
                return 0;

            if(cache.TryGetValue(target, out var value))
                return value;

            int res = (int)1e9;

            for(int i = 0; i < coins.Length; ++i){
                var coin = coins[i];
                if(target - coin >= 0){
                    res = Math.Min(res, 1 + DFS(target - coin));
                }
            }

            cache.Add(target, res);

            return res;
        }
    }
}
