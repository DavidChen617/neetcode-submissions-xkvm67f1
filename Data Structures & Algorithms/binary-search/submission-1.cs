public class Solution {
    public int Search(int[] nums, int target) {
      return BinarySearch(nums, target, 0, nums.Length-1);
    }

      private int BinarySearch(int[] nums, int target, int l, int r){
        if(l>r)
            return -1;
            
        int mid = (l + r) / 2;

        if(nums[mid] == target)
            return mid;

        if (nums[mid] > target)
            --r;
        else
            ++l;

        return BinarySearch(nums, target, l, r);
    }
}
