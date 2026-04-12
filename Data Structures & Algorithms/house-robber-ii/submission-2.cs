public class Solution {
    public int Rob(int[] nums) {
        var N = nums.Length;
        if(N == 0)
            return 0;

        if (N == 1)
            return nums[0];
        
        var memo = new int[N][];

        for(int i = 0; i < N; ++i)
            memo[i] = new int[]{-1, -1};
        
        return Math.Max(
            DFS(0, 1),
            DFS(1, 0)
        );

        int DFS(int n, int flag){
            if(n >= N)
                return 0;

            if(n == N-1 && flag == 1)
                return 0;
            
            if(memo[n][flag] == -1)
                memo[n][flag] = Math.Max(
                    DFS(n + 1, flag),
                    DFS(n + 2, (flag == 1 || n == 0)? 1 : 0 ) + nums[n]
                );

            return memo[n][flag];
        }
    }
}
