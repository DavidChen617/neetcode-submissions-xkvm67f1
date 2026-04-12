public class Solution {
    public int LengthOfLIS(int[] nums) {
       int n = nums.Length;
       int[,] cache = new int[n, n + 1];
       
       for(int i = 0; i < n; ++i){
            for(int j = 0; j <= n; ++j){
                cache[i, j] = -1;
            }
       }

       return DFS(0, -1);

       int DFS(int i, int j){
            if(i == n)
                return 0;
            
            if(cache[i, j + 1] != -1)
                return cache[i, j + 1];
            
            int lis = DFS(i + 1, j);

            if(j == -1 || nums[i] > nums[j])
                lis = Math.Max(1 + DFS(i + 1, i), lis);

            cache[i, j + 1] = lis;

            return lis;
       }
    }
}
