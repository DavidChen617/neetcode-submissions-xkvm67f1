public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length - 1;
        var memo = new Dictionary<int, int>();

        return DFS(0);

        int DFS(int index)
        {
            if(index == n)
                return 0;
            
            if(memo.TryGetValue(index, out var value))
                return value;
            
            if(nums[index] == 0)
                return 1_000_000;

            int res = 1_000_000,
                end = Math.Min(n, nums[index] + index);

            for (int i = index + 1; i <= end; i++)
            {
                res = Math.Min(res, 1 + DFS(i));
            }

            memo.Add(index, res);
            
            return res;
        }  
    }
}
