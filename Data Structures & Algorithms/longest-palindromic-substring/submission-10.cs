public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length, from = 0, take = 0;

        for(int i = 0; i < n; ++i){
            for(int j = i; j < n; ++j){
                int left = i, right = j;

                while(left < right && s[left] == s[right]){
                    ++left;
                    --right;
                }

                if(left >= right && (j - i + 1) > take){
                    take = j - i + 1;
                    from = i;
                }
            }
        }

        return s.Substring(from, take);
    }
}
