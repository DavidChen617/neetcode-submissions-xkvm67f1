public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        var sub = new List<int>();
        Dfs(nums, result, sub , 0);

        return result;
    }

    private void Dfs(int[] nums, List<List<int>>result, List<int> sub, int index){
        if(index >= nums.Length){
            result.Add(new List<int>(sub));
            return ;
        }

        sub.Add(nums[index]);
        Dfs(nums, result, sub , index + 1);
        sub.RemoveAt(sub.Count - 1);
        Dfs(nums, result, sub , index + 1);
    }
}
