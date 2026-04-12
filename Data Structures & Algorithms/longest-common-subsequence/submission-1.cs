public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        var(ROW, COL) = (text1.Length, text2.Length);
        var dp = new int[ROW+1, COL+1];

        for(int r = ROW-1; r >= 0; --r){
            for(int c = COL-1; c >= 0; --c){
                if(text1[r] == text2[c]){
                    dp[r, c] = 1+dp[r+1, c+1];
                }else{
                    dp[r, c] = Math.Max(dp[r+1, c], dp[r, c+1]);
                }
            }
        }

        return dp[0, 0];
    }
}
