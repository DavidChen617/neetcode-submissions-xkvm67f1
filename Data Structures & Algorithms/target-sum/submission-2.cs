public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        var dp = new Dictionary<(int, int), int>();

        return DFS(0, 0);

        int DFS(int index, int curSum){

            if(index == nums.Length){
                return curSum == target? 1 : 0;
            }

            if(dp.TryGetValue((index, curSum), out var value))
                return value;

            var res = DFS(index + 1, curSum + nums[index]) +
                DFS(index + 1, curSum - nums[index]);

            dp.Add((index, curSum), res);

            return res;
        }
    }
}
