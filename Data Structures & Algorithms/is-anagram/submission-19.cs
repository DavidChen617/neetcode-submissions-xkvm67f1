public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        var count = new int[26];
        for(int i = 0; i < s.Length; ++i){
            var ks = s[i] - 'a';
            var kt = t[i] - 'a';

            ++count[ks];
            --count[kt];
        }

        for(int i = 0; i < 26; ++i){
            if(count[i] != 0)
                return false;
        }

        return true;
    }
}
