public class Solution {
    private static int[][] Direction = new int[][]
    {
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, 1},
        new int[] {0, -1},
    }; 
    public int MaxAreaOfIsland(int[][] grid) {
        var result = 0;
        var (ROW, COL) =(grid.Length, grid[0].Length);
        
        for (int r = 0; r < ROW; r++)
        {
            for (int c = 0; c < COL; c++)
            {
                if (grid[r][c] == 1)
                {
                    var count = BST(r, c);
                    if (count > result)
                        result = count;
                }
            } 
        }
        
        return result;
        
        int BST(int r, int c)
        {
           var q = new Queue<(int row, int col)>();
           grid[r][c] = 0;
           q.Enqueue((r, c));
           int count =  1;

           while (q.Count > 0)
           {
               var (row, col) = q.Dequeue();
               foreach (var dir in Direction)
               {
                   var (nr, nc) = (row+dir[0], col+dir[1]);
                   if (nr >= 0 && nc >= 0 && nr < ROW && nc < COL && grid[nr][nc] == 1)
                   {
                       q.Enqueue((nr, nc));
                       grid[nr][nc] = 0;
                       ++count;
                   }
               }
           }

           return count;
        }
    }
}
