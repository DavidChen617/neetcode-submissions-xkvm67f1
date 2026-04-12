public class Solution
{
    private readonly int[][] direction = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };

    public void islandsAndTreasure(int[][] grid)
    {
        var (ROWS, COLS) = (grid.Length, grid[0].Length);
        for (int i = 0; i < ROWS; ++i)
            for (int j = 0; j < COLS; ++j)
                if (grid[i][j] == int.MaxValue)
                    grid[i][j] = BFS(i, j);

        int BFS(int r, int c)
        {
            var visited = new bool[grid.Length][];
            
            for (int i = 0; i < ROWS; i++)
                visited[i] = new bool[COLS];
            
            visited[r][c] = true;
            var q = new Queue<(int row, int col)>();
            q.Enqueue((r, c));
            var step = 0;

            while (q.Any())
            {
                var size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    var (row, col) = q.Dequeue();

                    if (grid[row][col] == 0)
                        return step;

                    foreach (var dir in direction)
                    {
                        var (nr, nc) = (row + dir[0], col + dir[1]);
                        if (Math.Min(nr, nc) < 0 || nr >= ROWS || nc >= COLS || grid[nr][nc] == -1 || visited[nr][nc])
                            continue;
                        visited[nr][nc] = true;
                        q.Enqueue((nr, nc));
                    }
                }

                ++step;
            }
            return int.MinValue;
        }
    }
}
