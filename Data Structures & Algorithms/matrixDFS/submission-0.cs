public class Solution {
    private int[][] Dircetion = new int[][]{        
        new []{1, 0},
        new []{-1, 0},
        new []{0, 1},
        new []{0, -1}
    };
    public int CountPaths(int[][] grid) {
        var count = DFS(0, 0, new HashSet<string>());
        return count;
        
        int DFS(int r, int c, HashSet<string> visit)
        {
            if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 1 || visit.Contains($"{r},{c}"))
                return 0;
            
            if(r == grid.Length - 1 &&  c == grid[0].Length - 1)
                return 1;
            
            visit.Add($"{r},{c}");
            var count = 0;
            
            foreach (var dir in Dircetion)
            {
                var (row, col) = (r+dir[0], c+dir[1]);
                count += DFS(row, col, visit);
            }

            visit.Remove($"{r},{c}");            
            
            return count;
        }
    }
}
