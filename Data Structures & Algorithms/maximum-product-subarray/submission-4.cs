public class Solution {
    public int MaxProduct(int[] nums) {
        int res = nums[0], curMax = 1, curMin = 1;

        foreach(var num in nums){
            int max_num = num * curMax, min_num = num * curMin;

            curMax = Math.Max(Math.Max(max_num, min_num), num);
            curMin = Math.Min(Math.Min(max_num, min_num), num);
            res = Math.Max(res, curMax);
        }

        return res;
    }
}
