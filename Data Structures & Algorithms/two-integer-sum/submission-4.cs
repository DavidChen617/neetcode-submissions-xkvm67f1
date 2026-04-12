public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; ++i){
            var remaining = target - nums[i];

            if(dic.TryGetValue(remaining, out var index))
                return new int[]{index, i};

            dic.Add(nums[i], i);
        }

        return new int[]{-1, -1};
    }
}
