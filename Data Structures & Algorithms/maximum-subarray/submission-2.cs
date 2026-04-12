public class Solution {
    public int MaxSubArray(int[] nums) {
        return DFS(0, false);

        int DFS(int index, bool flag)
        {
            if (index >= nums.Length)
                return flag ? 0 : (int)-1e6;

            if (flag)
                return Math.Max(0, nums[index] + DFS(index + 1, true));

            return Math.Max(
                DFS(index + 1, false),
                nums[index] + DFS(index + 1, true)
            );
        }
    }
}
