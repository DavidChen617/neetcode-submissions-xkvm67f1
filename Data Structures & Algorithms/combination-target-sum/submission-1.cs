public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        var sub = new List<int>();
        DFS(0, 0);

        return result;
        
        void DFS(int index, int total)
        {
            if (total == target)
            {
                result.Add(new List<int>(sub));
                return;
            }
            
            if(total > target || index >= nums.Length)
                return;
            
            sub.Add(nums[index]);
            DFS(index, total + nums[index]); // 選
            sub.RemoveAt(sub.Count - 1); // 反悔, 拿掉最後一個
            DFS(index + 1, total); // 下一步
        }
    }
}
