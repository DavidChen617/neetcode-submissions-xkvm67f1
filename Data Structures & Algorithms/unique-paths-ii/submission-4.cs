public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var ROW = obstacleGrid.Length;
        var COL = obstacleGrid[0].Length;
        var dp = new int[COL+1];
        dp[COL-1] =1;
        for (int i = ROW-1; i >= 0; --i)
        {
            for (int j = COL-1; j >= 0; --j)
            {
                if(obstacleGrid[i][j] == 1)        
                    dp[j] = 0;
                else
                {
                    dp[j] += dp[j + 1];
                }
            }
        }
        return dp[0];
    }
}