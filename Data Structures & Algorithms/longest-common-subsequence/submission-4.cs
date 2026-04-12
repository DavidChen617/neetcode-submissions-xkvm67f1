public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
       if(text1.Length < text2.Length){
            var tmp = text1;
            text1 = text2;
            text2 = tmp;
       }
       var (ROW, COL) = (text1.Length, text2.Length);

       var dp = new int[COL+1];

       for(int r = ROW-1; r >= 0; --r){
            var prev = 0;
            for(int c = COL-1; c >= 0; --c){
                var temp = dp[c];
                if(text1[r] == text2[c])
                    dp[c] = 1 + prev;
                else{
                    dp[c] = Math.Max(dp[c], dp[c+1]);
                }
                prev = temp;
            }
       }
       return dp[0];
    }
}
