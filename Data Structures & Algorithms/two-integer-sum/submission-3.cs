public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var d = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; ++i){
            var key = target - nums[i];

            if(d.TryGetValue(key, out var value))
                return new int[]{value, i};

            d.Add(nums[i], i);
        }

        return new int[]{-1, -1};
    }
}
