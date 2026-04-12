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
                    count = Math.Max(DFS(r, c, 0), count);
                }
            }
        }

        return count;

        int DFS(int r, int c, int count){
            if(Math.Min(r, c) < 0 || r >= ROWS || c >= COLS || grid[r][c] != 1)
                return count;
            
            ++count;
            grid[r][c] = 0;

            foreach(var dir in directions)
               count = DFS(r + dir[0], c + dir[1], count);

            return count;
        }
    }
}









