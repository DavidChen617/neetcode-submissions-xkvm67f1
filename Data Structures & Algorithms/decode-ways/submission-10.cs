public class Solution {
    public int NumDecodings(string s) {
        var cache = new Dictionary<int ,int>();

        return DFS(0);

        int DFS(int i){
            if(i == s.Length)
                return 1;

            if(s[i] == '0')
                return 0;

            if(cache.TryGetValue(i, out var value))
                return value;
            
            int res = DFS(i + 1);

            if(i + 1 < s.Length)
                if(s[i] == '1' || (s[i] == '2' && s[i + 1] < '7'))
                    res += DFS(i + 2);

            cache.Add(i, res);

            return res;
        }
    }
}
