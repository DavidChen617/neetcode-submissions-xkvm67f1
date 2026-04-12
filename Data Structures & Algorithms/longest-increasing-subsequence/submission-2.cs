public class Solution {
    public int LengthOfLIS(int[] nums) {
        var n = nums.Length;
        var cache = new int[n, n + 1];
        
        for(int i = 0; i < nums.Length; ++i)
            for(int j = 0; j <= nums.Length; ++j)
                cache[i, j] = -1;

        return DFS(0, -1);

        int DFS(int i, int j){
            if(i == nums.Length)
                return 0;

            if(cache[i, j + 1] != -1)
                return cache[i, j + 1];

            var lis = DFS(i + 1, j);

            if(j == -1 || nums[i] > nums[j])
                lis = Math.Max(lis, DFS(i + 1, i) + 1);

            cache[i, j + 1] = lis;
            return lis;
        }        
    }
}
