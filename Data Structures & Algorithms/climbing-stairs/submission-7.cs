public class Solution {
    public int ClimbStairs(int n) {     
        int[] cache = new int[n+1];

        for(int i = 0; i <= n; ++i)
            cache[i] = -1;

        return DFS(n);

        int DFS(int step){
            if(step <= 1)
                return 1;

            if(cache[step] != -1)
                return cache[step];

            return cache[step] = DFS(step - 1) + DFS(step - 2);
        }
    }
}
