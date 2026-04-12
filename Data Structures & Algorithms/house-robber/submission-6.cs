public class Solution {
    public int Rob(int[] nums) {
        int[] cache = new int[nums.Length];

        for(int i = 0; i < nums.Length; ++i)
            cache[i] = -1;

        return DFS(0);

        int DFS(int n){
            if(n >= nums.Length)
                return 0;

            if(cache[n] != -1)
                return cache[n];

            return cache[n] = Math.Max(
                DFS(n + 1), 
                DFS(n + 2) + nums[n]
            );
        }
    }
}
