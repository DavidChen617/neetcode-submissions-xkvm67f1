public class Solution {

    public string Encode(IList<string> strs) {
        var res = string.Empty;
        var sb = new StringBuilder();

        foreach(var s in strs){
            res += s.Length.ToString() + ',';
            sb.Append(s);
        }

        res += '#' + sb.ToString();

        return res;
    }

    public List<string> Decode(string s) {
        var sizes = new List<int>();
        int index = 0;

        while(s[index] != '#'){
            var cur = string.Empty;

            while(s[index] != ','){
                cur += s[index];
                ++index;
            }

            sizes.Add(int.Parse(cur));
            ++index;
        }
        ++index;
        var res = new List<string>();

        foreach(var size in sizes){
            res.Add(s.Substring(index, size));
            index += size;
        }

        return res;
   }
}
