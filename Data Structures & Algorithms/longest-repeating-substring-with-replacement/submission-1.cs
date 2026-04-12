public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0,
            n = s.Length;
        var set = new HashSet<char>(s);

        foreach(var c in set){
            int l = 0,
                count = 0;

            for(int r = 0; r < n; ++r){
                if(s[r] == c)
                    ++count;

                while((r - l + 1) - count > k){
                    if(s[l] == c)
                        --count;
                    ++l;
                }

                res = Math.Max(res, (r - l + 1));
            }
        }

        return res;
    }
}
