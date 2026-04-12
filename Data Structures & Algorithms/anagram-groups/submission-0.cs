public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();
        int n = strs.Length;

        for(int i = 0; i < n; ++i){
            var count = new int[26];

            for(int j = 0; j < strs[i].Length; ++j){
                count[strs[i][j] - 'a']++;
            }

            var key = string.Join(",", count);

            if(!dic.ContainsKey(key))
                dic[key] = new List<string>();
            
            dic[key].Add(strs[i]);
        }

        return dic.Values.ToList<List<string>>();
    }
}
