public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
                if (grid[0][0] == 1)
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
        
        var q = new Queue<(int row, int col)>();
        q.Enqueue((0, 0));
        var length = 1;
        grid[0][0] = 1;
        
        while (q.Any())
        {
            var size = q.Count;
            while (size-- > 0)
            {
                var (row, col) = q.Dequeue();
                
                foreach (var direction in directions)
                {
                    var (nr, nc) = (row +  direction.row, col + direction.col);
                    if(nr < 0 || nc < 0 || nr > grid.Length -1 || nc > grid[0].Length - 1 || grid[nr][nc] == 1)
                        continue;
                    
                    if(nr == grid.Length - 1 && nc == grid[0].Length - 1)
                        return length +1;
                    
                    grid[nr][nc] = 1;
                    q.Enqueue((nr, nc));
                }
            }

            ++length;
        }
        
        return -1;
    }
}