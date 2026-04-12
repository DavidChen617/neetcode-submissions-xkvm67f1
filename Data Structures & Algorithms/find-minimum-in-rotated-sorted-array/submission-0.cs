public class Solution {
    public int FindMin(int[] nums) {
        int res = nums[0];
        int l = 0, r = nums.Length - 1;
        
        while(l <= r){
            if(nums[l] < nums[r])
                res = Math.Min(nums[l], res);
            
            int m = l + (r - l) / 2;
            res = Math.Min(nums[m], res);
            if(nums[m] >= nums[l])
                l = m + 1;
            else
                r = m - 1;
        } 

        return res; 
    }
}
