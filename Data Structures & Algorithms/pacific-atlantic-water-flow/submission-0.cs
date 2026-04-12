public class Solution 
{
    public List<List<int>> PacificAtlantic(int[][] heights)
    {
        var directions = new (int row, int col)[]{
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1),
        };
        
        var pac = new HashSet<(int, int)>();
        var atl = new HashSet<(int, int)>();
        var (ROWS, COLS) = (heights.Length, heights[0].Length);
        
        for (int c = 0; c < COLS; c++)
        {
            DFS(0, c, pac);
            DFS(ROWS-1, c, atl);
        }
        
        for (int r = 0; r < ROWS; r++)
        {
            DFS(r, 0, pac);
            DFS(r, COLS-1, atl);
        }
        
        var result = new List<List<int>>();
        
        for (int r = 0; r < ROWS; r++)
            for (int c = 0; c < COLS; c++)
                if(pac.Contains((r, c)) &&  atl.Contains((r, c)))
                    result.Add(new List<int>{r, c});
        
        return result;
        
        void DFS(int r, int c, HashSet<(int, int)> ocean)
        {
            ocean.Add((r, c));
            
            foreach (var (row, col) in directions)
            {
                var (nr, nc) = (r + row, c + col );
                
                if(Math.Min(nr, nc) < 0 || nr >= ROWS || nc >= COLS || ocean.Contains((nr, nc)))
                    continue;
                
                if(heights[nr][nc] < heights[r][c])
                    continue;
                
                DFS(nr, nc, ocean);
            }
        }
    }
}
