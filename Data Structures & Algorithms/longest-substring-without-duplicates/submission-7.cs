public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s))
            return 0;

        if(string.IsNullOrWhiteSpace(s))
            return 1;

        var counts = new int[128];
        int res = 0, l = 0;

        for (int r = 0; r < s.Length; ++r) {
            ++counts[s[r]];

            while (counts[s[r]] > 1) {
                --counts[s[l]];
                ++l;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
