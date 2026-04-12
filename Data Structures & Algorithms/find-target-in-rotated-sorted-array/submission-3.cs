public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int l = 0, r = n - 1;

        while(l < r){
            int m = l + (r - l) / 2;
            if(nums[m] > nums[r])
                l = m + 1;
            else
                r = m;
        }

        int pivot = l;
        var result = BinarySearch(0, pivot - 1);
        
        return result != -1 ? 
            result: BinarySearch(pivot, n - 1);

        int BinarySearch(int l, int r){
            while(l <= r){
                int m = l + (r - l) / 2;
                if(nums[m] == target)
                    return m;
                
                if(nums[m] < target)
                    l = m + 1;
                else
                    r = m - 1;
            }

            return -1;
        }
    }
}
