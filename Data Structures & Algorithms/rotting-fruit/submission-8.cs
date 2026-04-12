public class Solution {
    public int OrangesRotting(int[][] grid)
    {
        var directions = new (int row, int col)[]{
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1),
        };
        
        var q = new Queue<(int row, int col)>();
        var fresh = 0;

        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
            {
                var value = grid[i][j];
                if(value == 1)
                    ++ fresh;
                else if(value == 2)
                    q.Enqueue((i, j));
            }

        var times = 0;
        
        while (q.Any() && fresh > 0)
        {
            var size = q.Count;
            for (int i = 0; i < size; i++)
            {
                var (row, col) = q.Dequeue();
                
                foreach (var dir in directions)
                {
                    var (nr, nc) = (row +  dir.row, col + dir.col);
                    if(nr < 0 || nc < 0)
                        continue;
                    if(nr >= grid.Length || nc >= grid[0].Length)
                        continue;
                    if(grid[nr][nc] != 1)
                        continue;
                    
                    grid[nr][nc] = 2;
                    fresh--;
                    q.Enqueue((nr, nc));
                }
            }

            ++times;
        }

        return fresh == 0 ? times : -1;
    }
}
