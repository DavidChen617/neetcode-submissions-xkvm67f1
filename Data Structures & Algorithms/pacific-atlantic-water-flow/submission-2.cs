public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        var directions = new (int row, int col)[]{
            (1, 0),(-1, 0),
            (0, 1),(0, -1)
        };
        var (ROWS, COLS) = (heights.Length, heights[0].Length);
        var pac = new bool[ROWS, COLS];
        var atl = new bool[ROWS, COLS];
       
        for(int i = 0; i < ROWS; ++i){
            DFS(i, 0, pac);
            DFS(i, COLS-1, atl);
        }

        for(int i = 0; i < COLS; ++i){
            DFS(0, i, pac);
            DFS(ROWS-1, i, atl);
        }

        var result = new List<List<int>>();

        for(int r = 0; r < ROWS; ++r){
            for(int c = 0; c < COLS; ++c){
                if(pac[r,c] && atl[r,c])
                    result.Add(new List<int>(){r, c});
            }
        }

        return result;

        void DFS(int r, int c, bool[,] oecan){
            oecan[r, c] = true;

            foreach(var(row, col) in directions){
                var (nr, nc) = (row + r, col + c);

                if(Math.Min(nr, nc) < 0 || nr >= ROWS || nc >= COLS || oecan[nr, nc] || heights[nr][nc] < heights[r][c])
                    continue;

                DFS(nr, nc, oecan);
            }
        }
    }
}
