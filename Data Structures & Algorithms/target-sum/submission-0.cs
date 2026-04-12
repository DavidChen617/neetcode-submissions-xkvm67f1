public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        return DFS(0, 0);

        int DFS(int index, int curSum){

            if(index == nums.Length){
                return curSum == target? 1 : 0;
            }

            return DFS(index + 1, curSum + nums[index]) +
                DFS(index + 1, curSum - nums[index]);
        }
    }
}
