public class Solution {
    public int UniquePaths(int m, int n) {
        var prevRow = new int[n];
        
        for (int i = 0; i < m; i++)
        {
            var curRow = new int[n];
            curRow[n-1] = 1;
            
            for (int j = n-2; j >= 0; --j)
                curRow[j] = curRow[j+1] + prevRow[j];
            
            prevRow = curRow;
        }
        
        return prevRow[0];
    }
}
