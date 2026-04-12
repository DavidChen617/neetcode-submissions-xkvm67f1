public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 1)
            return nums.Length;

        int left = 1;

        for(int it = left; it < nums.Length; ++it){
            if(nums[it] != nums[it-1]){
                nums[left] = nums[it];
                ++left;
            }
        }

        return left;
    }
}