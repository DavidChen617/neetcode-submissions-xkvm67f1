public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sd = new Dictionary<char, int>();
        var td = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sd[s[i]] = sd.TryGetValue(s[i], out var v1) ? v1 + 1: 1;
            td[t[i]] = td.TryGetValue(t[i], out var v2) ? v2 + 1: 1;
        }

        if (sd.Count != td.Count)
            return false;

        foreach (var kv in sd)
        {
            if (!td.TryGetValue(kv.Key, out var value) || value != kv.Value)
                return false;
        }

        return true;
    }
}
