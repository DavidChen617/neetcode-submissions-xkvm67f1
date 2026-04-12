public class Solution {
    public List<List<int>> Permute(int[] nums) {
        if (nums.Length == 0)
            return new() { new()};

        var per = Permute(nums[1..]);
        var result = new List<List<int>>();
        var insertValue = nums[0];
        
        for (int i = 0; i < per.Count; i++)
        {
            for (int j = 0; j <= per[i].Count; j++)
            {
                var copy = new List<int>(per[i]);
                copy.Insert(j, insertValue);
                result.Add(copy);
            }
        }

        return result;
    }
}
