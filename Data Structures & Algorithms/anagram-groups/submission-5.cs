public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; ++i){
            var str = strs[i];
            var letters = new int[26];
            
            for(int j = 0; j < str.Length; ++j){
                var key = str[j] - 'a';
                ++letters[key];
            }

            var k = string.Join(",", letters);

            if(dic.TryGetValue(k, out var arr))
                arr.Add(str);
            else
                dic.Add(k, new List<string>{str});
        }

        return dic.Values.ToList();
    }
}
