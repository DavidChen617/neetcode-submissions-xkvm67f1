public class Solution {
    public int CharacterReplacement(string s, int k) {
        var counts = new int[26];
        int res = 0,
            l = 0,
            maxCount = 0;

        for(int r = 0; r < s.Length; ++r){
            ++counts[s[r] - 'A'];
            maxCount = Math.Max(maxCount, counts[s[r] - 'A']);

            while((r - l + 1) - maxCount > k){
                --counts[s[l] - 'A'];
                ++l;
            }

            res = Math.Max(res, r - l + 1);
        }
        
        return res;
    }
}
