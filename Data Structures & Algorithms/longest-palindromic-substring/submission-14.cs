public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length, from = 0, take = 0;
        var dp = new bool[n, n];

        for(int i = n - 1; i >= 0; --i){
            for(int j = i; j < n; ++j){
                if(s[i] == s[j] && (j - i < 3 || dp[i + 1, j - 1])){
                    if(j - i + 1 > take){
                        from = i;
                        take = j - i + 1;
                    }

                    dp[i, j] = true;
                }
            }
        }

        return s.Substring(from, take);
    }
}
