public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var prev = new int[n];
        var post = new int[n];
        var res = new int[n];
        prev[0] = 1;
        post[n-1] = 1;

        for(int i = 1; i < n; ++i)
            prev[i] = nums[i - 1] * prev[i - 1];
        
        for(int i = n - 2; i >= 0; --i)
            post[i] = nums[i + 1] * post[i + 1];

        for(int i = 0; i < n; ++i)
            res[i] = post[i] * prev[i];

        return res;
    }
}
