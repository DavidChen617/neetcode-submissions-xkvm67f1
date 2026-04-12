public class Solution {
    public void Solve(char[][] board) {
        var directions = new int [][]{
            new int []{1, 0},
            new int []{-1, 0},
            new int []{0, 1},
            new int []{0, -1},
        };

        var (ROWS, COLS) = (board.Length, board[0].Length);

        for(int c = 0; c < COLS; ++c){
            Capture(0, c);
            Capture(ROWS-1, c);
        }

        for(int r = 0; r < ROWS; ++r){
            Capture(r, 0);
            Capture(r, COLS-1);
        }

        for(int r = 0; r < ROWS; ++r)
            for(int c = 0; c < COLS; ++c){
                if(board[r][c] == 'O')
                    board[r][c] = 'X';

                if(board[r][c] == 'T')
                    board[r][c] = 'O';
            }

        void Capture(int r, int c){
            if(Math.Min(r, c) < 0 || r >= ROWS || c >= COLS || board[r][c] != 'O')
                return;

            board[r][c] = 'T';

            foreach(var dir in directions){
                Capture(r + dir[0], c + dir[1]);
            }
        }
    }
}
