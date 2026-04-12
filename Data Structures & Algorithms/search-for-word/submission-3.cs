public class Solution {
    public bool Exist(char[][] board, string word) {
        var (ROWS, COLS) = (board.Length, board[0].Length);
        var path = new HashSet<(int Row, int Col)>();

        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                if (DFS(r, c, 0))
                    return true;
            }
        }

        return false;

        bool DFS(int row, int col, int index)
        {
            if (index == word.Length)
                return true;

            if (Math.Min(row, col) < 0 || row >= ROWS || col >= COLS || board[row][col] != word[index] ||
                !path.Add((row, col)))
                return false;
            
            var res = DFS(row - 1, col, index + 1) ||
                      DFS(row + 1, col, index + 1) ||
                      DFS(row, col - 1, index + 1) ||
                      DFS(row, col + 1, index + 1);

            path.Remove((row, col));
            
            return res;
        }
    }
}
