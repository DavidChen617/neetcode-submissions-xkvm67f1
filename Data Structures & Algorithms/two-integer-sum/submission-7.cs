public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; ++i){
            var key = target - nums[i];

            if(dic.TryGetValue(key, out var value)){
                return new int[]{value, i};
            }

            dic.Add(nums[i], i);
        }

        return null;
    }
}
