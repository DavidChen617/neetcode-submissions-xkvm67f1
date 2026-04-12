public class Solution {
    public List<List<int>> Permute(int[] nums) {
        if (nums.Length == 0)
            return new (){new ()};

        var per = Permute(nums[1..]);
        var result = new List<List<int>>();

        for (int i = 0; i < per.Count; i++)
        {
            for (int j = 0; j <= per[i].Count; j++)
            {
                var sub = new List<int>(per[i]);
                sub.Insert(j, nums[0]);
                result.Add(new (sub));
            }
        }

        return result;
    }
}
