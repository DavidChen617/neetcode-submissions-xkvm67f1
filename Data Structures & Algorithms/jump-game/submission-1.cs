public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length - 1;
        var memo = new Dictionary<int, bool>();

        return DFS(0);

        bool DFS(int index)
        {
            if(memo.TryGetValue(index, out bool value))
                return value;
            
            if(index == n)
                return true;
            
            if(nums[index] == 0)
                return false;

            var end = Math.Min(n, index + nums[index]);
            
            for (int i = index + 1; i <= end; i++)
            {
                if (DFS(i))
                {
                    memo.Add(index, true);
                    return true;
                }
            }
            
            memo.Add(index, false);
            return false;
        }
    }
}
