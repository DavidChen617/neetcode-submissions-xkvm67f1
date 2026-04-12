public class Solution {
    public int ClimbStairs(int n) {
        var cache = new int[n]; 
        for(int i = 0; i < n; ++i)
            cache[i] = -1;

        return DFS(n, 0);

        int DFS(int n, int count){
            if(count >= n) 
                return count == n? 1 : 0;

            if(cache[count] == -1)
                cache[count] = DFS(n, count + 1) + DFS(n, count +2);

            return cache[count];
        }
    }
}
