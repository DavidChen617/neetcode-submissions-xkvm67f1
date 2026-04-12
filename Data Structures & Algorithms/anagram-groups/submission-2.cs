public class Solution {
     public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();
        
        for(int i = 0; i < strs.Length; ++i){
           var letters = new int[26];
           var str = strs[i];
           
           for(int j = 0; j < str.Length; ++j){
                ++letters[str[j] - 'a'];
           }

           var key = string.Join(",", letters);

           if(dic.TryGetValue(key, out var arr))
                arr.Add(str);
           else
                dic.Add(key, new List<string>(){str});
        }

        return dic.Values.ToList();
    }
}
