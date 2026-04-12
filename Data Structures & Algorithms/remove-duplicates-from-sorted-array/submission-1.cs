public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 1){
            return 1;
        }

        int left = 1;
        for(int it = 1; it<nums.Length; it++){
            if(nums[it] !=nums[it-1]){
                nums[left] = nums[it];
                ++left;
            }
        }

        return left;
    }
}