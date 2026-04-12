public class Solution {
    public int Search(int[] nums, int target) {
       int l = 0;
       int r = nums.Length - 1;
       while(l<=r){
            int mid = (r+l)/2;
            if(nums[mid] == target)
                return mid;
            if(nums[mid] > target)
                --r;
            else
                ++l;
       }    

       return -1;
    }
}
