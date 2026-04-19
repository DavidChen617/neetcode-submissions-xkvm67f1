public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)
            return false;
            
        int[] counts1 = new int[26],
            counts2 = new int[26];
        
        for(int i = 0; i < s1.Length; ++i){
            ++counts1[s1[i] - 'a'];
            ++counts2[s2[i] - 'a'];
        }

        int matches = 0;
        for(int i = 0; i < 26; ++i){
            if(counts1[i] == counts2[i])
                ++matches;
        }
        
        if(matches == 26)
            return true;

        for(int i = s1.Length; i < s2.Length; ++i){
            int r = s2[i] - 'a';
            int l = s2[i - s1.Length] - 'a';

            ++counts2[r];
            if(counts2[r] == counts1[r])
                ++matches;
            else if(counts2[r] == counts1[r] + 1)
                --matches;
            
            --counts2[l];
            if(counts2[l] == counts1[l])
                ++matches;
            else if(counts2[l] == counts1[l] - 1)
                --matches;
            
            if(matches == 26)
                return true;
        }

        return false;
    }
}
