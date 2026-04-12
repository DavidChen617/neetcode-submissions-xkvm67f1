public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var ROW = obstacleGrid.Length;
        var COL = obstacleGrid[0].Length;
        var dp = new int[ROW+1, COL+1];
        dp[ROW-1, COL-1] = 1;
        
        for (int i = ROW-1; i >= 0; --i)
        {
            for (int j = COL-1; j >= 0; --j)
            {
                if(obstacleGrid[i][j] == 1)        
                    dp[i, j] = 0;
                else
                {
                    dp[i, j] += dp[i+1, j];
                    dp[i, j] += dp[i, j+1];
                }
            }
        }
        return dp[0, 0];
    }
}