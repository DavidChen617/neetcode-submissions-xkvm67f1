public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        var sd = new Dictionary<char, int>();
        var td = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; ++i){
            sd[s[i]] = TryIncrementOrDefault(sd, s[i]);
            td[t[i]] = TryIncrementOrDefault(td, t[i]);
        }

        if(sd.Count != td.Count)
            return false;
        
        foreach(var (k , v) in sd)
            if(!td.TryGetValue(k, out var v2) || v2 != v)
                return false;

        return true;

        int TryIncrementOrDefault(Dictionary<char, int> d, char c){
            return d.TryGetValue(c, out var v)? v + 1: 1;
        }
    }
}
