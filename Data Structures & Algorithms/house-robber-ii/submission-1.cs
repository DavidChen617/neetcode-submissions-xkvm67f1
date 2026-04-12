public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        
        var memo = new int[nums.Length][];

        for(int i = 0; i < nums.Length; ++i)
            memo[i] = new int[]{-1, -1};

        return Math.Max(
            DFS(0, 1),
            DFS(1, 0)
        );

        int DFS(int n, int flag){
            if(n >= nums.Length)
                return 0;

            if(n == nums.Length - 1 && flag == 1)
                return 0;

            if(memo[n][flag] == -1)
                memo[n][flag] = Math.Max(
                    DFS(n + 1, flag),
                    nums[n] + DFS(n + 2, (flag == 1 || n == 0)? 1 : 0)
                );

            return  memo[n][flag];
        }
    }
}
