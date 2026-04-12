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

        var N =  grid.Length;
        var q = new Queue<(int row, int col, int len)>();
        q.Enqueue((0, 0, 1));
        grid[0][0] = 1;

        while (q.Any())
        {
            var size = q.Count;
            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                if(node.row == N - 1 && node.col == N - 1)
                    return node.len;
                
                foreach (var dir in directions)
                {
                    var (nr, nc) = (node.row + dir.row, node.col + dir.col);
                    
                    if(Math.Min(nr, nc) < 0 || Math.Max(nr, nc) >= N || grid[nr][nc] == 1)
                        continue;
                    grid[nr][nc] = 1;
                    q.Enqueue((nr, nc, node.len+1));
                }
            }
        }

        return -1;
    }
}