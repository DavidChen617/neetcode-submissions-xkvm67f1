public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length, 
            xor = n;
        
        for (int i = 0; i < n; i++)
        {
            xor = xor ^ i ^ nums[i];
        }
        
        return xor;
    }
}
