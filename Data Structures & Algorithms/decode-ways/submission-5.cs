public class Solution {
    public int NumDecodings(string s) {
        return DFS(0);

        int DFS(int i){
            if(i == s.Length)
                return 1;
                
            if(s[i] == '0')
                return 0;
            
            int res = DFS(i + 1);

            if(i < s.Length - 1){
                if(s[i] == '1' || (s[i] == '2' && s[i + 1] < '7'))
                    res += DFS(i + 2);
            }

            return res;
        }
    }
}
