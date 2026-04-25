public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(0, nums.Length - 1);

        int BinarySearch(int l, int r){
            if(l > r)
                return -1;
                
            int m = l + (r - l) / 2;

            if(nums[m] > target)
                return BinarySearch(l, m - 1);
            
            if(nums[m] < target)
                return BinarySearch(m + 1, r);

            return m;
        }
    }
}
