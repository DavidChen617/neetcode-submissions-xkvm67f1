public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length - 1;
        return DFS(0);

        bool DFS(int index){
            if(index == n)
                return true;
            if(nums[index] == 0)
                return false;

            var end = Math.Min(n, index + nums[index]);
            
            for(int i = index + 1; i <= end; ++i){
                if(DFS(i))
                    return true;
            }

            return false;
        }
    }
}
