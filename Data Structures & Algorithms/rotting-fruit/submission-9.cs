public class Solution {
    public int OrangesRotting(int[][] grid) {
        var result = 0;
        
        var directions = new (int row, int col)[]
        {
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1),
        };
        var fresh = 0;
        var (ROWS, COLS) =  (grid.Length, grid[0].Length);
        var q = new Queue<(int row, int col)>();
        
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                if(grid[r][c] == 1)
                    ++fresh;
                else if(grid[r][c] == 2)
                    q.Enqueue((r, c));
            }
        }

        while (q.Any() && fresh>0)
        {
            var size = q.Count;
            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                foreach (var diw in directions)
                {
                    var (nr, nc) = (node.row + diw.row, node.col + diw.col); 
                    
                    if(Math.Min(nr, nc) < 0 || nr >= grid.Length || nc >= grid[0].Length || grid[nr][nc] != 1)
                        continue;
                    
                    q.Enqueue((nr, nc)); 
                    grid[nr][nc] = 2;
                    --fresh;
                }
            }
            ++result;
        }

        return fresh == 0 ? result : -1;
    }
}
