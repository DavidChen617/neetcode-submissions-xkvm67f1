public class Solution {
    public int CountSubstrings(string s) {
        int res = 0, n = s.Length;

        for(int i = 0; i < n; ++i){
           Helper(i, i);
           Helper(i, i + 1);
        }

        return res;

        void Helper(int left, int right){
            while(left >= 0 && right < n && s[left] == s[right]){
                --left;
                ++right;
                ++res;
            }
        }
    }
}
