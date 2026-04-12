public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        var s1 = new Dictionary<char, int>();
        var t1 = new Dictionary<char, int>();
        
        for(var i = 0; i < s.Length; ++i){
            s1[s[i]] = s1.ContainsKey(s[i])? ++s1[s[i]] : 1;
            t1[t[i]] = t1.ContainsKey(t[i])? ++t1[t[i]] : 1;
        }

        foreach (KeyValuePair<char, int> pair in s1)
           if(!t1.TryGetValue(pair.Key, out var t1Count) || t1Count != pair.Value)
                return false;

        return true;
    }
}
