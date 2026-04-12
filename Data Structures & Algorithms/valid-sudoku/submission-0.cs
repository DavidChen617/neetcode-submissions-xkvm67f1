public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var row = new Dictionary<int, HashSet<char>>();
        var col = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<string, HashSet<char>>();

        for(int r = 0; r < 9; ++r){
            for(int c = 0; c < 9; ++c){
                var v = board[r][c];
                if(v == '.')
                    continue;
                    
                var spuareKey = $"{r / 3}, {c / 3}";
                
                if((row.ContainsKey(r) && row[r].Contains(v)) ||
                    (col.ContainsKey(c) && col[c].Contains(v)) ||
                    (squares.ContainsKey(spuareKey) && squares[spuareKey].Contains(v))
                    )
                    return false;
                
                if(!row.ContainsKey(r))
                    row[r] = new HashSet<char>();
                if(!col.ContainsKey(c))
                    col[c] = new HashSet<char>();
                if(!squares.ContainsKey(spuareKey))
                    squares[spuareKey] = new HashSet<char>();
                
                row[r].Add(v);
                col[c].Add(v);
                squares[spuareKey].Add(v);
            }
        }

        return true;
    }
}
