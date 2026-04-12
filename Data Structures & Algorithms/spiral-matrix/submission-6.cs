public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        (int right, int bottom, int top, int left) = (matrix[0].Length, matrix.Length, 0, 0);
        var result = new List<int>();
        
        while (left < right && top < bottom)
        {
            for (int i = left; i < right; i++)
                result.Add(matrix[top][i]);
            ++top;

            for (int i = top; i < bottom; i++)
                result.Add(matrix[i][right - 1]);
            --right;
            
            if(!(left < right && top < bottom))
                break;
            
            for (int i = right-1; i >= left; i--)
                result.Add(matrix[bottom - 1][i]);
            --bottom;

            for (int i = bottom - 1; i >= top; i--)
                result.Add(matrix[i][left]);
            ++left;
        }
        
        return result;
    }
}
