public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length, from = 0, take = 0;
        Func<string> result = () => s.Substring(from, take);

        for(int i = 0; i < n; ++i){
            Helper(i, i);
            Helper(i, i+1);
        }

        return result();

        void Helper(int left, int right){
             while(left >= 0 && right < n && s[left] == s[right]){

                if(right - left + 1 > take){
                    take = right - left + 1;
                    from = left;
                }

                --left;
                ++right;
            }
        }
    }
}
