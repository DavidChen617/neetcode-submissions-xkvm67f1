public class Solution {
    public int LongestConsecutive(int[] nums) {
        var store = new HashSet<int>(nums);
        int res = 0;

        foreach(var num in store){
            int length = 1;

            if(!store.Contains(num - 1)){   
                while(store.Contains(num + length)){
                    ++length;
                }
            }

            res = Math.Max(length, res);
        }

        return res;
    }
}
