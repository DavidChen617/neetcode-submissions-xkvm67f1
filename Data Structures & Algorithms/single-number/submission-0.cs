public class Solution {
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);
        int i = 0;

        while(i < nums.Length){
            if(i == nums.Length - 1)
                 return nums[i];
                 
            if(nums[i] != nums[i + 1])
                return nums[i];

            i += 2;
        }

        return nums[nums.Length - 1];
    }
}
