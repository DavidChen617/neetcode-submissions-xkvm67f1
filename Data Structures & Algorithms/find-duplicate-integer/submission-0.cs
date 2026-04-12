public class Solution {
    public int FindDuplicate(int[] nums) {
        var set = new HashSet<int>();

        for(int i = 0; i < nums.Length; ++i){
            if(!set.Add(nums[i]))
                return nums[i];
        }

        return -1;
    }
}
