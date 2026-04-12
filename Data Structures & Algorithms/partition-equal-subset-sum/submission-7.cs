public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0, n = nums.Length;

        for(int i = 0; i < n; ++i)
            sum += nums[i];

        if(sum % 2 != 0)
            return false;
        
        var half = sum / 2;
        var cache = new bool?[n + 1, half + 1];

        return DFS(0, half);

        bool DFS(int i, int target){
            if(i == n)
                return target == 0;
            
            if(target < 0)
                return false;

            if(cache[i, target] != null)
                return cache[i, target] == true;

            var result = DFS(i + 1, target) || DFS(i + 1, target - nums[i]);
            cache[i, target] = result;

            return result;
        }
    }
}
