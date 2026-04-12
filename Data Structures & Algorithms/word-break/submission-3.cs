public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        var dic = new Dictionary<int, bool>{
            {s.Length, true}
            };

        return DFS(0);

        bool DFS(int i){
            if(dic.TryGetValue(i, out var v))
                return v;
            
            foreach(var w in wordDict){
                if(i + w.Length <= s.Length && 
                s.Substring(i, w.Length) == w){
                    if(DFS(i+w.Length)){
                        dic[i] = true;
                        return true;
                    }
                }
            }

            dic[i] = false;
            return false;
        }
    }
}
