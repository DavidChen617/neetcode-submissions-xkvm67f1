public class Solution {
    public void SetZeroes(int[][] matrix) {
        (int m, int n) = (matrix.Length, matrix[0].Length);
        bool[] rowZeros = new bool[m], colZeros = new bool[n];

        for (int r = 0; r < m; ++r)
            for (int c = 0; c < n; ++c)
                if (matrix[r][c] == 0)
                {
                    rowZeros[r] = true;
                    colZeros[c] = true;
                }

        for (int r = 0; r < m; ++r)
            for (int c = 0; c < n; ++c)
                if(rowZeros[r] ||  colZeros[c])
                    matrix[r][c] = 0;

    }
}
