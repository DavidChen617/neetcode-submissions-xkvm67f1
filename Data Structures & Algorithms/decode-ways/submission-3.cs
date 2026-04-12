public class Solution {
    public int NumDecodings(string s) {
        var dp = new Dictionary<int, int>();
        var n = s.Length;
        dp[n] = 1;

        return DFS(0);

        int DFS(int i){
            if(dp.TryGetValue(i, out var value))
                return value;
            
            if(s[i] == '0')
                return 0;
            
            var res = DFS(i + 1);

            if(i < n - 1){
                var v = s[i];
                if(v == '1' || (v == '2' && s[i + 1] < '7'))
                    res+=DFS(i + 2);
            }

            dp[i] = res;

            return res;
        }
    }
}
