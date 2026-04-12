public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) { 
       int ROWS = matrix.Length;
       int COLS = matrix[0].Length;
       int top = 0, bot = ROWS-1, row = 0;

       while(top <= bot){
            row = (top + bot) / 2;
            if(target > matrix[row][COLS-1])
                top = row+1;
            else if(target < matrix[row][0])
                bot = row-1;
            else
                break;
       }

       if(top > bot)
          return false;
        int left = 0, right = COLS-1, col = 0;
        while(left <= right){
            col = (left + right) / 2;
            if(target == matrix[row][col])
                return true;
            else if(target > matrix[row][col])
                 left = col+1;
            else
                 right = col-1;
        }

        return false;
    }
}
