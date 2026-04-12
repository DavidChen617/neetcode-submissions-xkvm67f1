public class Solution {
    public int ShortestPath(int[][] grid) {
         var directions = new (int row, int col)[]{
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1),
        };
        
        int length = 0;
        var q = new  Queue<(int row, int col)>();
        q.Enqueue((0, 0));
        var hashSet = new HashSet<string>();

        while (q.Any())
        {
            var size = q.Count;
            
            for (int i = 0; i < size; ++i)
            {
                
                var (row, col) = q.Dequeue();
                var key = $"{row},{col}";
                
                if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] == 1 || hashSet.Contains(key))
                    continue;
                
                if (row == grid.Length - 1 && col == grid[0].Length -1)
                    return length;
                
                hashSet.Add(key);
                
                foreach (var dir in directions)
                    q.Enqueue((row + dir.row, col + dir.col));
            }

            ++length;
        }

        return -1;
    }
}
