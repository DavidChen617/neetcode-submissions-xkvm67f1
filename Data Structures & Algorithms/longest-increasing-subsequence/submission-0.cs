public class Solution {
    public int LengthOfLIS(int[] nums) {
        return DFS(0, -1);

        int DFS(int i, int j){
            if(i == nums.Length)
                return 0;
            
            var LIS = DFS(i + 1, j);
            
            if(j == -1 || nums[i] > nums[j])
                LIS = Math.Max(1 + DFS(i + 1, i), LIS);
            
            return LIS;
        }
    }
}
