public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length, resIdx = 0, resLen = 0;
        var dp = new bool[n, n];

        for(int l = n - 1; l >= 0; --l){
            for(int r = l; r < n; ++r){
                var condition1 = s[r] == s[l];
                var condition2 = r - l + 1 <= 2;

                if(condition1 && (condition2 || dp[l+1, r-1])){
                    dp[l, r] = true;
                    var count = r - l + 1;
                    if(count > resLen){
                        resLen = count;
                        resIdx = l;
                    }
                }
            }
        }

        return s.Substring(resIdx, resLen);
    }
}
