public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        for (int it = 1; it < nums.Length; ++it){
            if(nums[it] != nums[it-1]){
                nums[k] = nums[it];
                ++k;
            }
        }

        return k;
    }
}