public class Solution {
    private static int[][] Direction = new int[][]
    {
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, 1},
        new int[] {0, -1},
    }; 
    
    public int MaxAreaOfIsland(int[][] grid)
    {
        var result = 0;
        
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                if (grid[i][j] == 1)
                    result = Math.Max(DFS(i, j), result);
        
        return result;
        
        int DFS(int r, int c)
        {
            if(Math.Min(r, c) < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 0)
                return 0;
            
            grid[r][c] = 0;
            var count = 1;
            
            foreach (var dir in Direction)
                count += DFS(r + dir[0], c + dir[1]);
            
            return count;
        }
    }
}