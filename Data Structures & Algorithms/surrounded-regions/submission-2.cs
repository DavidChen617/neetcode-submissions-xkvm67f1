public class Solution
{
    public void Solve(char[][] board)
    {
        var directions = new (int row, int col)[]
        {
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1),
        };

        var (ROWS, COLS) = (board.Length, board[0].Length);

        for (int i = 0; i < ROWS; i++)
        {
            if (board[i][0] == 'O')
                capture(i, 0);
            if (board[i][COLS - 1] == 'O')
                capture(i, COLS - 1);
        }

        for (int i = 0; i < COLS; i++)
        {
            if (board[0][i] == 'O')
                capture(0, i);

            if (board[ROWS - 1][i] == 'O')
                capture(ROWS - 1, i);
        }

        for (int i = 0; i < ROWS; i++)
            for (int j = 0; j < COLS; j++){
                if(board[i][j] == 'O')
                    board[i][j] = 'X';
                if(board[i][j] == 'T')
                    board[i][j] = 'O';
            }
               
        void capture(int r, int c)
        {
            if (Math.Min(r, c) < 0 || r == ROWS || c == COLS || board[r][c] != 'O')
                return;
            
            board[r][c] = 'T';
            
            foreach (var (row, col) in directions)
                capture(row + r, col + c);
        }
    }
}