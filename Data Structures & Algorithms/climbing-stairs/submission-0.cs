public class Solution {
    public int ClimbStairs(int n) {     
        var cache = new int[n];
        for(var j = 0; j < n; ++j)
            cache[j] = -1;
        
        return dfs(n, 0);

        int dfs(int n, int i){
            if(i >= n)
                return i == n? 1 : 0;

            if(cache[i] != -1)
                return cache[i];
           
            return cache[i] = dfs(n, i+1) + dfs(n, i+2);
        }
    }
}
