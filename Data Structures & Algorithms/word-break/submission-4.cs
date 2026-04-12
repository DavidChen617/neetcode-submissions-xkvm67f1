public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        var n = s.Length;
        var dp = new bool[n + 1];
        dp[n] = true;

        for(int i = n - 1; i >= 0; --i)
            foreach(var w in wordDict){
                var wl = w.Length;

                if(i + wl <= n && s.Substring(i, wl) == w)
                    dp[i] = dp[i + wl];

                Print();

                if(dp[i])
                    break;
            }
    
        return dp[0];

        void Print(){
            Console.WriteLine("Start");
            foreach(var i in dp){
                Console.WriteLine(i);
            }
            Console.WriteLine("End");
        }
    }
}
