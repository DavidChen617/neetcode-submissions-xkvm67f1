public class Solution {
    int[][] Direction = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };
    
    public int CountPaths(int[][] grid) { 
      var visited = new bool[grid.Length,grid[0].Length];
        
      return DFS(0, 0);
      
      int DFS(int r, int c)
      {
          if (Math.Min(r,c) < 0 || r >= grid.Length || c >= grid[0].Length || visited[r,c] || grid[r][c] ==1)
              return 0;
          if (r == grid.Length - 1 && c == grid[0].Length - 1)
              return 1;
          
          visited[r, c] = true;
          var count = 0;
          foreach (var dir in Direction)
              count += DFS(r + dir[0], c + dir[1] );
          
          visited[r, c] = false;
          
          return count;
      }
    }
}