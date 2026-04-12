public class Solution {
    public int[] CountBits(int n) {
        var nums = new int[n + 1];
        
        for (int num = 1;  num <= n; num++)
        {
            for (int i = 0; i < 32; i++)
            {
                if ((num & (1 << i)) != 0)
                {
                    ++nums[num];
                }
            }
        }
        
        return nums;
    }
}
