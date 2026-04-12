public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var cache = new int[cost.Length];
        for(int i = 0; i < cost.Length; ++i)
            cache[i] = -1;
            
        return Math.Min(
            DFS(0), DFS(1)
        );

        int DFS(int n){
            if(n >= cost.Length)
                return 0;

            if(cache[n] == -1)
               cache[n] = Math.Min(DFS(n + 1), DFS(n + 2));

            return cost[n] + cache[n];
        }
    }
}
