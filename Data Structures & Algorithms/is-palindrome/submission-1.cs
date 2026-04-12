public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0,
            r = s.Length - 1;

        while(l < r){
            while(l < r && !AlphaNum(s[l]))
                ++l;
            while(r > l && !AlphaNum(s[r]))
                --r;
            if(char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;

            ++l; --r;
        }

        return true;
    }

    private bool AlphaNum(char c) => 
        (c >= 'a' && c <= 'z' ) ||
        (c >= 'A' && c <= 'Z' ) ||
        (c >= '0' && c <= '9' );
}
