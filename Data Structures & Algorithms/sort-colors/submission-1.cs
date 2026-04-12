public class Solution {
    public void SortColors(int[] nums) {
        var colors = new int[3];
    
        foreach (var n in nums)
            ++colors[n];
    
        int i = 0;
        
        for (int j = 0; j < colors.Length; ++j)
            for (int k = 0; k < colors[j]; ++k)
                nums[i++] = j;
    }
}