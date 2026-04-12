public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        var n = grid.Length;
        if (grid[0][0] == 1 || grid[n-1][n-1] == 1)
            return -1;
        
        var directions = new(int row, int col)[]{
           (-1, 0), // 上 
           (1, 0), // 下
           (0, -1), // 左
           (0, 1), // 右
           (-1, -1), // 左上
           (-1, 1), // 右上
           (1, -1), // 左下
           (1, 1)// 右下
        };
        
        var q = new Queue<(int row, int col, int length)>();
        q.Enqueue((0, 0, 1));
        grid[0][0] = 1;
        
        while (q.Any())
        {
            var (row, col, len) = q.Dequeue();
            
            if(row == n - 1 && col == n - 1)
                return len;
            
            foreach (var direction in directions)
            {
                var (nr, nc) = (row +  direction.row, col + direction.col);
                
                if(nr < 0 || nc < 0 || nr > n -1 || nc > n - 1 || grid[nr][nc] == 1)
                    continue;
                
                grid[nr][nc] = 1;
                q.Enqueue((nr, nc, len +1));
            }
        }
        
        return -1;
    }
}