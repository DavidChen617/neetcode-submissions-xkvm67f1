public class Solution {
    public void Solve(char[][] board) {
        int ROWS = board.Length, COLS = board[0].Length;
        var directions = new int[][]{
            new int[]{1, 0},
            new int[]{-1, 0},
            new int[]{0, 1},
            new int[]{0, -1},
        };

        for(int i = 0; i < COLS; ++i){
            if(board[0][i] == 'O')
                Capture(0, i);

            if(board[ROWS-1][i] == 'O')
                Capture(ROWS-1, i);
        }

        for(int i = 0; i < ROWS; ++i){
            if(board[i][0] == 'O')
                Capture(i, 0);
                
            if(board[i][COLS-1] == 'O')
                Capture(i, COLS-1);
        }

        for(int r = 0; r < ROWS; ++r){
            for(int c = 0; c < COLS; ++c){
                if(board[r][c] == 'O'){
                    board[r][c]='X';
                }
                 if(board[r][c] == 'T'){
                    board[r][c]='O';
                }
            }
        }

        void Capture(int r, int c){
             if(Math.Min(r, c) < 0 || r >= ROWS || c >= COLS || board[r][c] != 'O')
                return ;

            board[r][c] = 'T';

            foreach(var dir in directions)
                Capture(r+dir[0], c+dir[1]);
        }
    }
}
