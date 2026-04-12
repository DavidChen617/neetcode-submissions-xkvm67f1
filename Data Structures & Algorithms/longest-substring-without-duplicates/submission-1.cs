public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0,
            res = 0,
            n = s.Length;
        var set = new HashSet<char>();

        for(int r = 0; r < n; ++r){
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
