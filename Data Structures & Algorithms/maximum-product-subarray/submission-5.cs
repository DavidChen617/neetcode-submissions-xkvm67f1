public class Solution {
    public int MaxProduct(int[] nums) {
        int res = nums[0], n = nums.Length;

        for(int i = 0; i < n; ++i){
            int cur = nums[i];
            res = Math.Max(res, cur);
            
            for(int j = i + 1; j < n; ++j){
                cur *= nums[j];
                res = Math.Max(res, cur);
            }
        }

        return res;
    }
}
