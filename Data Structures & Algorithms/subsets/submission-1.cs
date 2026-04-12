public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        var sub = new List<int>();

        DFS(0);
        return result;

        void DFS(int i)
        {
            if (i >= nums.Length)
            {
                result.Add(new (sub));
                return;
            }

            sub.Add(nums[i]); // 選
            DFS(i + 1); // 往下走
            sub.RemoveAt(sub.Count - 1); // 不選
            DFS(i + 1); // 往下走
        }
    }
}
