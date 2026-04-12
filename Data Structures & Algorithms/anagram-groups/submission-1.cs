public class Solution {
     public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();
        
        for(int i = 0; i < strs.Length; ++i){
            var str = strs[i];
            var cs = str.ToCharArray();
            Array.Sort(cs);
            var key = new string(cs);
            if(dic.TryGetValue(key, out var value))
                value.Add(str);
            else
                dic.Add(key, new List<string>{str});
        }

        return dic.Values.ToList();
    }
}
