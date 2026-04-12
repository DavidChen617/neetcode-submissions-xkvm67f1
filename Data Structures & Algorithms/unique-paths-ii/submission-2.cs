public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var cached = new Dictionary<string, int>();
        return DFS(0, 0);

        int DFS(int r, int c)
        {
            if(r >= obstacleGrid.Length || c >= obstacleGrid[0].Length || obstacleGrid[r][c] == 1)
                return 0;
            if(r == obstacleGrid.Length - 1 && c == obstacleGrid[0].Length-1)
                return 1;

            var key = $"{r},{c}";

            if(!cached.ContainsKey(key))
                cached[key] = DFS(r+1, c) + DFS(r, c +1);

            return cached[key];
        }
    }
}