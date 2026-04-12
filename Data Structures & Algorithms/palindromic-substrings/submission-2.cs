public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length, res = 0;
        var dp = new bool[n, n];

        for(int i = n - 1; i >= 0; --i)
            for(int j = i; j < n; ++j){
                if(s[i] == s[j] && (j - i < 3 || dp[i + 1, j - 1])){
                    dp[i, j] = true;
                    ++res;
                }
            }

        return res;
    }
}
