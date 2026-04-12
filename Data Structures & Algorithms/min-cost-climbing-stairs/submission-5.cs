public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var cache = new Dictionary<int, int>();

        return Math.Min(DFS(0), DFS(1));

        int DFS(int i){
            if(i >= cost.Length)
                return 0;

            if(cache.TryGetValue(i, out var value))
                return value;

            var res = cost[i] + Math.Min(DFS(i + 1),DFS(i + 2));
            cache.Add(i, res);
            
            return res;
        }
    }
}
