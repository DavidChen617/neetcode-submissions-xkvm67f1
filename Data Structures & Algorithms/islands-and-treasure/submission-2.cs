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
        var q = new Queue<(int row, int col)>();

        for (int i = 0; i < ROWS; i++)
            for (int j = 0; j < COLS; j++)
                if (grid[i][j] == 0)
                    q.Enqueue((i, j));

        if (!q.Any())
            return;

        while (q.Any())
        {
            var (row, col) = q.Dequeue();
            foreach (var dir in direction)
            {
                var (nr, nc) = (row + dir[0], col + dir[1]);

                if (Math.Min(nr, nc) < 0 || nr >= ROWS || nc >= COLS || grid[nr][nc] != int.MaxValue)
                    continue;

                q.Enqueue((nr, nc));
                grid[nr][nc] = grid[row][col] + 1;
            }
        }
    }
}
