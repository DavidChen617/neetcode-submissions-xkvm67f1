public class Solution {
    /**
     delete = i + 1, j
     insert = i , j + 1
     replace = i + 1, j + 1
    */
    public int MinDistance(string word1, string word2) {
        (int m, int n) = (word1.Length, word2.Length);
        
        var dp = new int[m + 1, n + 1];

        for(int i = 0; i <= n; ++i){
            dp[m, i] = n - i;
        }

        for(int i = 0; i <= m; ++i){
            dp[i, n] = m - i;
        }

        for(int i = m - 1; i >= 0; --i){
            for(int j = n - 1; j >= 0; --j){
                if(word1[i] == word2[j]){
                    dp[i, j] = dp[i + 1, j + 1];
                }
                else{
                    dp[i, j] = 1 + 
                    Math.Min(
                        // delete
                        dp[i + 1, j], Math.Min(
                        // insert
                        dp[i, j + 1], 
                        // replace
                        dp[i + 1, j + 1])
                    );
                }
            }
        }

        return dp[0, 0];
    }
}
