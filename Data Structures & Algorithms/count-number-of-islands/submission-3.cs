public class Solution {
    private readonly int[][] direction = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };
    
    public int NumIslands(char[][] grid)
    {
        var (ROWS, COLS) = (grid.Length, grid[0].Length);
        var count = 0;
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                if (grid[r][c] == '1')
                {
                    DFS(r, c);
                    ++count;
                }
            }
        }
        
        return count;

        void DFS(int r, int c)
        {
            if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == '0')
                return;
            
            grid[r][c] = '0';
            
            foreach (var dir in direction)
                DFS(r + dir[0], c  + dir[1]);
        }
    }
}
