public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var res = new List<List<int>>();
        var sub = new List<int>();

        DFS(0, 0);

        return res;
        
        void DFS(int index, int total)
        {
            if (total == target)
            {
                res.Add(new List<int>(sub));
                return;
            }

            if (total > target || index >= nums.Length)
                return;

            sub.Add(nums[index]);
            DFS(index, total + nums[index]);
            sub.RemoveAt(sub.Count - 1);
            DFS(index + 1, total);
        }
    }
}
