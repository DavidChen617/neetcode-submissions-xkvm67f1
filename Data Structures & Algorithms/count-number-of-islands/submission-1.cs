public class Solution {
    int[][] Direction = new int[][]{
        new int[]{1, 0},
        new int[]{-1, 0},
        new int[]{0, 1},
        new int[]{0, -1}
    };

    public int NumIslands(char[][] grid) {
        int ROW = grid.Length, COL = grid[0].Length;
        var result = 0;

        for(int r = 0; r < ROW; ++r){
            for(int c = 0; c < COL; ++c){
                if(grid[r][c] == '1'){
                    BSD(r, c);
                    ++result;
                }
            }
        }

        return result;

        void BSD(int r, int c){
            var q = new Queue<(int row, int col)>();
            q.Enqueue((r, c));
            grid[r][c] = '0';
            while(q.Count > 0){
                var node = q.Dequeue();
                foreach(var dir in Direction){
                    var(row, col) = (node.row + dir[0], node.col + dir[1]);
                    if(row >= 0 && col >= 0 
                    && row < grid.Length && col < grid[0].Length
                    && grid[row][col] == '1'){
                        grid[row][col] = '0';
                        q.Enqueue((row, col));
                    }
                }
            }
        }
    }
}
