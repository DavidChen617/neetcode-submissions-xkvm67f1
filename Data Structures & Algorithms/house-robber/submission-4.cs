public class Solution {
    public int Rob(int[] nums) {
        var memo = new int[nums.Length];

        for(int i = 0; i < nums.Length; ++i)
            memo[i] = -1;
        
        return DFS(0);

        int DFS(int n){
            if(n >= nums.Length)
                return 0;
            if(memo[n] != -1)
                return memo[n];
            
            memo[n] = Math.Max(
                DFS(n + 1),
                nums[n] + DFS(n + 2));

            return memo[n];
        }
    }
}
