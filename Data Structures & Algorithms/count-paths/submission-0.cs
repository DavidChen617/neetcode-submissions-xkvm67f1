public class Solution {
    public int UniquePaths(int m, int n) {
        return DFS(0, 0);

        int DFS(int r, int c)
        {
            if (r >= m || c >= n)
                return 0;
            
            if(r == m-1 && c == n-1)
                return 1;
            
            return DFS(r+1, c) +  DFS(r, c+1);
        }
    }
}
