public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        int l = 0, 
            n = s.Length,
            res = 0;
        
        for(int r = 0; r < n; ++r){
            var c = s[r];

            while(set.Contains(c)){
                set.Remove(s[l]);
                ++l;
            }

            set.Add(c);
            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
