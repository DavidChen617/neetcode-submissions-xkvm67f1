public class Solution {
    public bool Exist(char[][] board, string word) {
        int ROWS = board.Length,
            COLS = board[0].Length;
        var paths = new HashSet<(int ROW, int COL)>();
        
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
                if(DFS(i, j, 0))
                    return true;
            }
        }
        return false;

        bool DFS(int r, int c, int index)
        {
            if(index == word.Length)
                return true;
            if(r < 0 || c < 0 || r >= ROWS || c >= COLS || word[index] != board[r][c] || !paths.Add((r, c)))
                return false;
            
            var res = DFS(r + 1, c, index + 1) ||
                      DFS(r - 1, c, index + 1) ||
                      DFS(r , c + 1, index + 1) ||
                      DFS(r, c - 1, index + 1);
            paths.Remove((r, c));
            return res;
        }
    }
}
