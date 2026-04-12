public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0, n = nums.Length;

        for(int i = 0; i < n; ++i)
            sum += nums[i];
        
        if(sum % 2 != 0)
            return false;
            
        var helf =  sum / 2;
        var cache = new bool?[n + 1, helf + 1];

        return DFS(0, helf);

        bool DFS(int i, int target){
            if(i == n)
                return target == 0;
            
            if(target < 0)
                return false;

            if(cache[i, target] != null)
                return cache[i, target] == true;

            var res = DFS(i + 1, target) || DFS(i + 1, target - nums[i]);
            cache[i, target] = res;

            return res;
        }
    }
}
