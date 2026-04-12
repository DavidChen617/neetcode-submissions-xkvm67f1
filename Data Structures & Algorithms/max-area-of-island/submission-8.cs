public class Solution {
    private static int[][] Direction = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 },
    };

    public int MaxAreaOfIsland(int[][] grid)
    {
        var result = 0;
        var (ROWS, COLS) = (grid.Length, grid[0].Length);
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                if(grid[r][c] == 1)
                    result = Math.Max(result, DFS(r, c));
            }
        }

        return result;
        
        int DFS(int r, int c)
        {
            if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 0)
                return 0;
            
            grid[r][c] = 0;
            var count = 1;
            
            foreach (var dir in Direction)
                count += DFS(r + dir[0], c + dir[1]);

            return count;
        }
    }

}
