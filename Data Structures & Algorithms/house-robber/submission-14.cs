public class Solution {
    public int Rob(int[] nums) {
        var cache = new Dictionary<int, int>();

        return DFS(0);

        int DFS(int i){
            if(i >= nums.Length)
                return 0;
                
            if(cache.TryGetValue(i, out var value))
                return value;

            var res = Math.Max(DFS(i + 1),DFS(i + 2) + nums[i]);
            cache.Add(i, res);

            return res;
        }
    }
}
