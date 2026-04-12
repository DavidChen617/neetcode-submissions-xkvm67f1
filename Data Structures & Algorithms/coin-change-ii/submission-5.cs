public class Solution {
    public int Change(int amount, int[] coins) {
        int M = coins.Length + 1,
            N = amount + 1;

        var dp = new int[M, N];

        for (int i = 0; i < M; i++)
        for (int j = 0; j < N; j++)
            dp[i, j] = -1;

        return DFS(0, amount);

        int DFS(int index, int amt)
        {
            if (amt == 0)
                return 1;

            if (index >= coins.Length)
                return 0;
            
            if (dp[index, amt] != -1)
                return dp[index, amt];

            int res = DFS(index + 1, amt);

            if (amt >= coins[index])
                res += DFS(index, amt - coins[index]);

            return dp[index, amt] = res;
        }
    }
}
