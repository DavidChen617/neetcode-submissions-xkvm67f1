public class Solution {
    public string LongestPalindrome(string s) {
        int resLen = 0, resIdx = 0, n = s.Length;
        var dp = new bool[n, n];

        for(int i = n-1; i >= 0; --i){
            for(int j = i; j < n; ++j){
                if(s[i] == s[j] && (j - i <= 2 || dp[i + 1, j -1])){
                    dp[i, j] = true;
                    var count = j - i + 1;

                    if(count > resLen){
                        resLen = count;
                        resIdx = i;
                    }
                }
            }
        }

        return s.Substring(resIdx, resLen);
    }
}
