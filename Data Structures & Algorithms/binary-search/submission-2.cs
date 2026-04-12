public class Solution {
    public int Search(int[] nums, int target) {
        return Search(0, nums.Length - 1);
        
        int Search(int l, int r){
            if (l > r)
             return -1;

            int m = l + (r - l) / 2;
            
            if(nums[m] == target)
                return m;
            if(target > nums[m])
                l = m + 1;
            else
                r = m - 1;
            
            return Search(l, r);
        }
    }
}
