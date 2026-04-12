public class Solution {
    public int CountSubstrings(string s) {
        var n = s.Length;
        var dp = new bool[n,n];
        var res = 0;

        for(int l = n - 1; l >=0; --l){
            for(int r = l; r < n; ++r){
                if(s[r] == s[l] && (r - l + 1 <= 2 || dp[l+1, r-1])){
                    ++res;
                    dp[l, r] = true;
                }
            }
        }

        return res;
    }
}
