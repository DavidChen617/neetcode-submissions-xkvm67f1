public class Solution {
    public void SortColors(int[] nums) {
        int[] count = new int[3];
        foreach(var n in nums)
            count[n]++;
        
        int index = 0;
        for(int i = 0; i < 3; ++i){
           while(count[i]-- > 0){
                nums[index++] = i;
           }
        }
    }
}