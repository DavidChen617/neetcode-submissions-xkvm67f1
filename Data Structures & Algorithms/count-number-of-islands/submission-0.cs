public class Solution {
    static int[][] Direction = new int[][] {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
    };

    public int NumIslands(char[][] grid) {
        var result = 0;
        int ROW = grid.Length,  COL = grid[0].Length;

        for (int w = 0; w < ROW; ++w)
        {
            for (int c = 0; c < COL; ++c)
            {
                if (grid[w][c] == '1')
                {
                   ++result;
                   BST(w, c);
                }
            }
        }

        return result;

        void BST(int r, int c)
        {
            grid[r][c] = '0';
            var q = new Queue<(int row, int col)>();
            q.Enqueue((r, c));

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                foreach (var d in Direction)
                {
                    int nr = node.row + d[0], nc = node.col + d[1];
                    if (nr >= 0 && nc >= 0 && nr < grid.Length && nc < grid[0].Length && grid[nr][nc] == '1')
                    {
                        q.Enqueue((nr, nc));
                        grid[nr][nc] = '0';
                    }
                }
            }
        }
    }
}
