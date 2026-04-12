public class Solution {
    public int Change(int amount, int[] coins) {
        Array.Sort(coins);
        var memo = new int[coins.Length + 1, amount + 1];

        for(int i = 0; i <= coins.Length; ++i)
            for(int j = 0; j <= amount; ++j)
                memo[i,j] = -1;

        return DFS(0, amount);

        int DFS(int index, int amt){
            if(amt == 0)
                return 1;

            if(index >= coins.Length)
                return 0;

            if(memo[index, amt] != -1)
                return memo[index, amt];

            int res = 0;

            if(amt >= coins[index]){
                res = DFS(index + 1, amt);
                res += DFS(index, amt - coins[index]);
            }

            memo[index, amt] = res;

            return res;
        }
    }
}
