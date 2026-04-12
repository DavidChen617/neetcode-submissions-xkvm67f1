public class Solution {
    private readonly int[][] direction = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };
    
        // grid = [
        // [0, 0, 0, 0],
        // [1, 1, 0, 0],
        // [0, 0, 0, 1],
        // [0, 1, 0, 0]
        // ]
    public int CountPaths(int[][] grid)
    {
        return DFS(0, 0);

        int DFS(int r, int c)
        {
            if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 1)
                return 0;
                
            if(r == grid.Length-1  && c == grid[0].Length -1)
                return 1;
            
            grid[r][c] = 1;
            var count = 0;
            
            foreach (var dir in direction)
                count += DFS(r + dir[0], c + dir[1]);
            
            grid[r][c] = 0;
            
            return count;
        }
    }
}
