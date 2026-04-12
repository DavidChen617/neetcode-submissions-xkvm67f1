public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        for(int i = 0, j = i + 1;j < nums.Length; ++j, ++i){
            if(nums[i] == nums[j])
                return true;
        }
        return false;
    }
}