public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int res = 0;
        var set = new HashSet<char>();

        for(int l = 0, r = 0; r < s.Length; ++r){
            while(set.Contains(s[r])){
                set.Remove(s[l]);
                ++l;
            }

            set.Add(s[r]);

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
