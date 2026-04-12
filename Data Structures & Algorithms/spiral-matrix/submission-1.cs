public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        int top = 0, left = 0, 
        bottom = matrix.Length - 1,
        right = matrix[0].Length - 1;

        var result = new List<int>();
        while(top <= bottom && left <= right){
            for(int i = left; i <= right; ++i){
                result.Add(matrix[top][i]);
            }
            ++top;

            for(int row = top; row <= bottom; ++row){
                result.Add(matrix[row][right]);
            }
            --right;

            if(top <= bottom){
                for(int col = right; col >= left; --col){
                    result.Add(matrix[bottom][col]);
                }
                bottom--;
            }

            if(left <= right){
                for(int row = bottom; row >= top; --row){
                    result.Add(matrix[row][left]);
                }

                ++left;
            }
        }

        return result;
    }
}
