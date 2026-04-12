public class Solution {
    public readonly int[][] directions = new int[][]{
        new int[]{1, 0},
        new int[]{-1, 0},
        new int[]{0, 1},
        new int[]{0, -1}
    };

    public int NumIslands(char[][] grid) {
        var result = 0;
        var (ROWS, COLS) = (grid.Length, grid[0].Length);

        for(var r = 0; r < ROWS; ++r){
            for(var c = 0; c < COLS; ++c){
                if(grid[r][c] == '1'){
                    ++result;
                    BFS(r, c);
                }
            }
        }

        return result;

        void BFS(int r, int c){
            var q = new Queue<(int row, int col)>();
            q.Enqueue((r, c));

            while(q.Any()){
                var (row, col) = q.Dequeue();
                grid[row][col] = '0';

                foreach(var dir in directions){    
                    var (nr, nc) = (row + dir[0], col + dir[1]);

                    if(Math.Min(nr, nc) < 0 || nr >= ROWS || nc >= COLS || grid[nr][nc] != '1')
                        continue;

                    q.Enqueue((nr, nc));
                }
            }
        }
    }
}








