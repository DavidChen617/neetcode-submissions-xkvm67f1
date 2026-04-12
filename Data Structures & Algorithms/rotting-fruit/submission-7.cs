public class Solution {
    public int OrangesRotting(int[][] grid) {
        var directions = new (int row, int col)[]{
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1),
        };
        
        var fresh = 0;
        var q = new Queue<(int row, int col)>();

        for (int row = 0; row < grid.Length; row++)
            for (int col = 0; col < grid[0].Length; col++)
            {
                var value = grid[row][col];
                if (value == 1)
                  ++fresh;
                else if (value == 2)
                  q.Enqueue((row, col));
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
                    var (nr, nc)= (row + dir.row, col + dir.col);
                    
                    if(nr < 0 || nc < 0 || nr >= grid.Length || nc >= grid[0].Length || grid[nr][nc] != 1)
                        continue;
                    
                    grid[nr][nc] = 2;
                    q.Enqueue((nr, nc));
                    --fresh;
                }
            }
            
            ++times;
        }
        
        return fresh == 0 ? times : -1;
    }
}
