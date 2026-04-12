public class Solution {
    public int RemoveDuplicates(int[] nums) {
       int k = 1;
       for(var i = k; i < nums.Length; ++i){
            if(nums[i] != nums[i-1]){
                nums[k] = nums[i];
                ++k;
            }
       }
       return k;
    }
}