public class Solution {
    private readonly int[][] directions = new int[][]{
        new int[]{1, 0},
        new int[]{-1, 0},
        new int[]{0, 1},
        new int[]{0, -1}
    };

    public List<List<int>> PacificAtlantic(int[][] heights) {
        var pac = new HashSet<(int, int)>();
        var atl = new HashSet<(int, int)>();
        var (ROWS, COLS) = (heights.Length, heights[0].Length);

        for(int i = 0; i < COLS; ++i){
            DFS(0, i, pac);
            DFS(ROWS-1, i, atl);
        }

        for(int i = 0; i < ROWS; ++i){
            DFS(i, 0, pac);
            DFS(i, COLS-1, atl);
        }

        var result = new List<List<int>>();

        for(int i = 0; i < ROWS; ++i)
            for(int j = 0; j < COLS; ++j)
                if(pac.Contains((i, j)) && atl.Contains((i, j)))
                    result.Add(new List<int>(){i, j});

        return result;

        void DFS(int r, int c, HashSet<(int, int)> ocean){
            ocean.Add((r, c));

            foreach(var dir in directions){
                var (nr, nc) = (r + dir[0], c + dir[1]);

                if(Math.Min(nr, nc) < 0 || nr == ROWS || nc == COLS || ocean.Contains((nr, nc)))
                    continue;

                if(heights[nr][nc] >= heights[r][c])
                    DFS(nr, nc, ocean);
            }
        }
    }
}
