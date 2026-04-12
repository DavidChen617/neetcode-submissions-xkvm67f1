public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        var set = new HashSet<string>(wordDict);
        var cache = new Dictionary<int, bool>();
        int sL = s.Length;
        return DFS(0);

        bool DFS(int i){
            if(i == sL)
                return true;

            if(cache.TryGetValue(i, out var value))
                return value;
            
            for(int j = i; j < sL; ++j){
                int from = i, take = j - i + 1;
                var subStr = s.Substring(from, take);

                if(set.Contains(subStr) && DFS(j + 1)){
                    cache[i] = true;
                    return true;
                }
            }
            
            cache[i] = false;
            return false;
        }
    }
}
