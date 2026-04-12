public class Solution {
    public int LongestConsecutive(int[] nums) {
        var store = new HashSet<int>(nums);
        int res = 0;
        
        for(int i = 0; i < nums.Length; ++i){
            int curr = nums[i], streak = 0;

            while(store.Contains(curr)){
                ++curr;
                ++streak;
            }

            res = Math.Max(streak, res);
        }

        return res;
    }
}
