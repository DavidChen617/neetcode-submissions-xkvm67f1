public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = matrix.Length, 
            col = matrix[0].Length,
            top = 0,
            bot = matrix.Length -1;

        while(top <= bot){
            row = top + (bot - top) / 2;
            
            if(target > matrix[row][col-1])
                top = row + 1;
            else if(target < matrix[row][0])
                bot = row - 1;
            else
                break;
        }

        if(top > bot)
            return false;
        
        return BinarySearch(0, col-1);

        bool BinarySearch(int l, int r){
            if(l > r)
                return false;

            int m = l + (r - l) / 2;

            if(matrix[row][m] == target)
                return true;
            
            return matrix[row][m] > target?
                BinarySearch(l , m - 1):
                BinarySearch(m + 1, r);
        }
    }
}
