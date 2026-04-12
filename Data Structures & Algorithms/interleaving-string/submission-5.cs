public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if(s1.Length + s2.Length != s3.Length)
            return false;

        return DFS(0, 0, 0);

        bool DFS(int i, int j, int k){

            if(k == s3.Length){
                return s1.Length == i && s2.Length == j;
            }

            var res = false;

            if(i < s1.Length && s1[i] == s3[k])
                res = DFS(i + 1, j, k + 1);

            if(!res && j < s2.Length && s2[j] == s3[k])
                res = DFS(i, j + 1, k + 1);

            return res;
        }
    }
}
