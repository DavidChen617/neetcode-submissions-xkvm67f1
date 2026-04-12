public class Solution {
    public string LongestPalindrome(string s) {
        int idx = 0, strLen = 0;

        for(int i = 0; i < s.Length; ++i){
            // odd
            int l = i, r = i;

            while(l>=0 && r < s.Length && s[l] == s[r]){
                if((r - l + 1) > strLen){
                    idx = l;
                    strLen = r - l + 1;
                }
                --l;
                ++r;
            }

            l = i;
            r = i + 1;
            while(l>=0 && r < s.Length && s[l] == s[r]){
                if((r - l + 1) > strLen){
                    idx = l;
                    strLen = r - l + 1;
                }

                --l;
                ++r;
            }
        }

        return s.Substring(idx, strLen);
    }
}
