public class Solution {
    public int MaxProduct(int[] nums) {
        var res = nums[0];

        for(int i = 0; i < nums.Length; ++i){
            int cur = nums[i];
            res = Math.Max(res, cur);

            for(int j = i + 1; j < nums.Length; ++j){
                cur *= nums[j];
                res = Math.Max(res, cur);
            }
        }
        
        return res;
    }
}
