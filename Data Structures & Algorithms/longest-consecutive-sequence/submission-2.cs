public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int longest = 0;
        
        foreach(var num in set){
            int length = 1;

            if(!set.Contains(num - 1)){
                while(set.Contains(num + length)){
                    ++length;
                }
            }

            longest = Math.Max(length, longest);
        }

        return longest;
    }
}
