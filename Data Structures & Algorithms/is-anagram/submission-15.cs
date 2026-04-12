public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
            
        var sc = s.ToCharArray();
        var tc = t.ToCharArray();

        Array.Sort(sc);
        Array.Sort(tc);

        for(int i = 0; i < Math.Max(sc.Length, tc.Length); ++i){
            if(sc[i] != tc[i])
             return false;
        }

        return true;
    }
}
