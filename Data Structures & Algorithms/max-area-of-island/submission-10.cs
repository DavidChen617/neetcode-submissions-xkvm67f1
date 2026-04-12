public class Solution {
    public readonly int[][] directions = new int[][]{
        new int[]{1, 0},
        new int[]{-1, 0},
        new int[]{0, 1},
        new int[]{0, -1}
    };

    public int MaxAreaOfIsland(int[][] grid) {
        var(ROWS, COLS) = (grid.Length, grid[0].Length);
        var count = 0;

        for(var r = 0; r < ROWS; ++r){
            for(var c = 0; c < COLS; ++c){
                if(grid[r][c] == 1){
                    grid[r][c] = 0;
                    count = Math.Max(BFS(r, c), count);
                }
            }
        }

        return count;

        int BFS(int r, int c){
            var q = new Queue<(int row, int col)>();
            grid[r][c] = 0;
            q.Enqueue((r, c));
            var count = 0;

            while(q.Any()){
                var (row, col) = q.Dequeue();    
                ++count;

                foreach(var dir in directions){
                    var (nr, nc) = (row + dir[0], col + dir[1]);

                    if(Math.Min(nr, nc) < 0 || nr >= ROWS || nc >= COLS || grid[nr][nc] != 1)
                        continue;
                    grid[nr][nc] = 0;
                    q.Enqueue((nr, nc));
                }
            }

            return count;
        }
    }
}









