public class Solution {
    public int NumDecodings(string s) {
        var n = s.Length;
        var dp = new int[n + 1];
        dp[n] = 1;

        for(int i = n - 1; i >= 0; --i){
            if(s[i] == '0')
                dp[i] = 0;
            else{
                // first way
                dp[i] = dp[i+1];
                // second way
                if(i + 1 < s.Length){
                    if(s[i] == '1' || (s[i] == '2' && s[i + 1] < '7'))
                        dp[i] += dp[i + 2];
                }
            }
        }

        return dp[0];
    }
}
