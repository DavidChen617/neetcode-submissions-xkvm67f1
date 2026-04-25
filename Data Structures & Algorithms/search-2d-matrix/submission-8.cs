public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix.Length == 0)
            return false;
        
        (int M, int N) = (matrix.Length, matrix[0].Length);
        int row = FindRow(0, M - 1);
        
        if(row == -1)
            return false; 
        
        return BinarySearch(0, N - 1) != -1;  

        int FindRow(int top, int bot){
            if(top > bot)
                return -1;
            
            int m = top + (bot - top) / 2;
            
            if(target < matrix[m][0])
                return FindRow(top, m - 1);
            
            if(target > matrix[m][N - 1])
                return FindRow(m + 1, bot);
            
            return m;
        }

        int BinarySearch(int l, int r){
            if(l > r)
                return -1;
            
            int m = l + (r - l) / 2;

            if(target > matrix[row][m])
                return BinarySearch(m + 1, r);
            
            if(target < matrix[row][m])
                return BinarySearch(l, m - 1);
            
            return m;
        }
    }
}
