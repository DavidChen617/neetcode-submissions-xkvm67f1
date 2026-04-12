public class Solution {
    public int ClimbStairs(int n) {     
        int[] cache = new int[n];

        for(int i = 0; i < n; ++i)
            cache[i] = -1;

        return DFS(n, 0);

        int DFS(int n, int step){
            if(step >= n)
                return step == n ? 1 : 0;

            if(cache[step] != -1)
                return cache[step];

            return cache[step] = DFS(n, step + 1) + DFS(n, step + 2);
        }
    }
}
