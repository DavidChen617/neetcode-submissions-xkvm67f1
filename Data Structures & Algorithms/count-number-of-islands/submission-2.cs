public class Solution {
    private static int[][] Direction = new int[][]
    {
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, 1},
        new int[] {0, -1},
    }; 
    
    public int NumIslands(char[][] grid) {
        var (ROW, COL) = (grid.Length, grid[0].Length);
        var count = 0;
        for (int i = 0; i < ROW; i++)
            for (int j = 0; j < COL; j++)
                if (grid[i][j] == '1')
                {
                    DFS(i, j);
                    ++count;
                }

        return count;
        
        void DFS(int r, int c)
        {
            if (Math.Min(r, c) < 0 || r >= ROW || c >= COL || grid[r][c] == '0')
                return;
            
            grid[r][c] = '0';
            
            foreach (var dir in Direction)
                 DFS(r + dir[0], c + dir[1]);
        }
    }
}