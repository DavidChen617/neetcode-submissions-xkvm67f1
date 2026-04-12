public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length, res = 0;

        for(int i = 0; i < n; ++i)
            for(int j = i; j < n; ++j){
                int left = i, right = j;

                while(s[left] == s[right] && left < right){
                    ++left;
                    --right;
                }

                if(left >= right){
                    res++;
                }
            }

        return res;
    }
}
