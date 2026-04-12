public class Solution {
    public int ClimbStairs(int n) {
        var cache = new Dictionary<int, int>();

        return DFS(0);

        int DFS(int i){
            if(i >= n)
                return i == n? 1 : 0;

            if(cache.TryGetValue(i, out var value))
                return value;
            
            var result = DFS(i + 1) + DFS(i + 2);
            cache.Add(i, result);
            
            return result;
        }
    }
}
