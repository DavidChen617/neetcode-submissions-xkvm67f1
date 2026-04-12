public class Solution {
    public List<int> PartitionLabels(string s) {
        int n = s.Length;
        int[] map = new int[26];

        for(int i = 0; i < n; ++i)
            map[s[i] - 'a'] = i;

        int end = 0, start = 0;
        var res = new List<int>();

        for(int i = 0; i < n; ++i){
            char c = s[i];
            end = Math.Max(end, map[c - 'a']);
            
            if(end == i){
                res.Add(end - start + 1);
                start = i + 1;
            }
        } 

        return res;
    }
}
