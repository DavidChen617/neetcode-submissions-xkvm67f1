public class Solution {
    private readonly (int row, int col)[] directions = new (int row, int col)[]{
        (1, 0),
        (-1, 0),
        (0, -1),
        (0, 1),
    };

    public void Solve(char[][] board) {
        var (ROWS, COLS) = (board.Length, board[0].Length);
        
        for(int i = 0; i < COLS; ++i){
            capture(0, i);
            capture(ROWS-1, i);
        }

        for(int i = 0; i < ROWS; ++i){
            capture(i, 0);
            capture(i, COLS-1);
        }

        for(int r = 0; r < ROWS; ++r)
            for(int c = 0; c < COLS; ++c)
                if(board[r][c] == 'O')
                    board[r][c] = 'X';

         for(int r = 0; r < ROWS; ++r)
            for(int c = 0; c < COLS; ++c)
                if(board[r][c] == 'T')
                    board[r][c] = 'O';


        void capture(int r, int c){
            if(Math.Min(r, c) < 0 || r == ROWS || c == COLS || board[r][c] != 'O')
                return;

            board[r][c] = 'T';   

            foreach(var (row, col) in directions)
                capture(r + row, c + col);
        }
    }
}
