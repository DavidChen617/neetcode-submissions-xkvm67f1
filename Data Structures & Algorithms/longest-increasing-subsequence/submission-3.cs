public class Solution {
    public int LengthOfLIS(int[] nums) {
        return DFS(0, -1);

        int DFS(int i, int j){
            if(i == nums.Length)
                return 0;

            int lis = DFS(i + 1, j);

            if(j == -1 || nums[i] > nums[j])
                lis = Math.Max(lis, 1 + DFS(i + 1, i));

            return lis;
        }
    }
}
