public class Solution {
    public int OrangesRotting(int[][] grid) {
        var dircetions = new int [][]{
            new int[]{1, 0},
            new int[]{-1, 0},
            new int[]{0, 1},
            new int[]{0, -1},
        };

        var (ROWS, COLS) = (grid.Length, grid[0].Length);
        var q = new Queue<(int row, int col)>();
        var fresh = 0;

        for(var i = 0; i < ROWS; ++i)
            for(var j = 0; j < COLS; ++j){
                if(grid[i][j] == 2)
                    q.Enqueue((i, j));
                if(grid[i][j] == 1)
                  ++fresh;  
            }
        
        var result = 0;

        while(q.Count > 0 && fresh > 0){
            var size = q.Count;
            for(int i = 0; i < size; ++i){
                 var (row, col) = q.Dequeue();
                foreach(var dir in dircetions){
                    var (nr, nc) = (row + dir[0], col + dir[1]);

                    if(Math.Min(nr, nc) < 0 || nr >= ROWS || nc >= COLS || grid[nr][nc] != 1)
                        continue;

                    grid[nr][nc] = 2;
                    --fresh;

                    q.Enqueue((nr ,nc));
                }
            }   
            
            result++;
        }

        return fresh == 0? result : -1;
    }
}









