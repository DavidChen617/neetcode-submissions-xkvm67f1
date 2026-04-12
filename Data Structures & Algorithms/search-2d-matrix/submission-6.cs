public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        return Search(0, matrix.Length -1);
        
        bool Search(int top, int bot)
        {
            if(top > bot)
                return false;
            
            int m = top + (bot - top) / 2;
            var curRow = matrix[m];
            
            if (target < curRow[0])
                return Search(top, m - 1);
            if (target > curRow[curRow.Length - 1])
                return Search(m + 1, bot);
                
            foreach (var n in curRow)
                if(n ==  target)
                    return true;
            
            return false;
        }
    }
}
