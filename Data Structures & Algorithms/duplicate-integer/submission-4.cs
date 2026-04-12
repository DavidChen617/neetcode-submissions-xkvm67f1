public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        
        for(var i = 1; i < nums.Length; ++i)
            if(nums[i] == nums[i -1])
                return true;

        return false;
    }
}
