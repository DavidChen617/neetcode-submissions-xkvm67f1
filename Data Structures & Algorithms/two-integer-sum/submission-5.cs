public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; ++i){
            for(int j = i + 1; j < nums.Length; ++j){
                if ( ((target - nums[i]) - nums[j]) == 0 )
                    return new int[]{i, j};
            }
        }

        return new int[]{-1, -1};
    }
}
