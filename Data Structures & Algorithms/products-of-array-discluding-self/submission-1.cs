public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] prev = new int[n], post = new int[n], res = new int[n];
        prev[0] = 1;
        post[n-1] = 1;

        for(int i = 1; i < n; ++i){
            prev[i] = prev[i-1] * nums[i-1];
            int j = n - i - 1;
            post[j] = post[j + 1] * nums[j + 1];
        }

        for(int i = 0; i < n; ++i)
            res[i] = post[i] * prev[i];

        return res;
    }
}
