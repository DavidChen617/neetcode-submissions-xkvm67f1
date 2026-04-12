public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) { 
        var ROW = matrix.Length;
        var COL = matrix[0].Length;
        int top = 0, bot = ROW-1;
        int midRow = 0;
        while(top <= bot){
            midRow = (top + bot) / 2;
            if(target > matrix[midRow][COL-1])
                top = midRow+1;
            else if(target < matrix[midRow][0])
                bot = midRow-1;
            else
                break;
        }
       
        if(!(top <= bot))
            return false;
        
        int left = 0, right = COL-1;

        while(left <= right){
            int mid = (left + right) / 2;
            if(matrix[midRow][mid] == target)
                return true;
            if(matrix[midRow][mid] > target)
                right = mid - 1;
            else
                left = mid + 1;   
        }

        return false;
    }
}
