public class Solution {
    public int MaxSubArray(int[] nums) {
        var memo = new int[nums.Length + 1, 2];

        for (int i = 0; i < nums.Length; i++)
        {
            memo[i, 0] = memo[i, 1] = int.MinValue;
        }

        return DFS(0, false);

        int DFS(int index, bool flag)
        {
            if (index == nums.Length)
            {
                return flag ? 0 : -1_000_000;
            }

            var f = flag ? 1 : 0;

            if (memo[index, f] != int.MinValue)
                return memo[index, f];

             memo[index, f] = flag ? 
                Math.Max(0, nums[index] + DFS(index + 1, true)) :
                Math.Max(
                    DFS(index + 1, false),
                    nums[index] + DFS(index + 1, true));

            return memo[index, f];
        }
    }
}
