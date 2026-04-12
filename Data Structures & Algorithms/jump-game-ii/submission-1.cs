public class Solution {
    public int Jump(int[] nums) {
        var n = nums.Length - 1;
        return DFS(0);

        int DFS(int index)
        {
            if (index == n)
                return 0;

            if (nums[index] == 0)
                return 1_000_000;
            
            var end = Math.Min(n, index + nums[index]);
            var res = 1_000_000;

            for (int i = index + 1; i <= end; i++)
            {
                res = Math.Min(res, 1 + DFS(i));
            }
            
            return res;
        }  
    }
}
