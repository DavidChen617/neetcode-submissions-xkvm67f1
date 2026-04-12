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

        for(var r = 0; r < ROWS; ++r)
            for(var c = 0; c < COLS; ++c)
                if(grid[r][c] == '1'){
                    ++result;
                    DFS(r, c);
                }

        return result;

        void DFS(int r, int c){
            if(Math.Min(r, c) < 0 || r >= ROWS || c >= COLS || grid[r][c] != '1')
                return;

            grid[r][c] = '0';

            foreach(var dir in directions)
                DFS(r + dir[0], c + dir[1]);
        }
    }
}
