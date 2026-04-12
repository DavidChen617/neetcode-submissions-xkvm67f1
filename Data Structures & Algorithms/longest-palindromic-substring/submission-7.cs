public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length, from = 0, take = 0;

        for(int i = 0; i < n; ++i){
            Helper(i, i);
            Helper(i, i + 1);
        }

        return s.Substring(from, take);

        void Helper(int l, int r){
            while(l >= 0 && r < n && s[l] == s[r]){
                if(r - l + 1 > take){
                    from = l;
                    take = r - l + 1;
                }
                --l;
                ++r;
            }
        }
    }
}
