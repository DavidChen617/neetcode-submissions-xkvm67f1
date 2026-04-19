public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var dic = new Dictionary<char, char>();
        dic.Add('[', ']');
        dic.Add('{', '}');
        dic.Add('(', ')');

        for (int i = 0; i < s.Length; ++i) {
            var c = s[i];

            if (dic.ContainsKey(c)) {
                stack.Push(c);
                continue;
            }

            if(stack.Count < 1)
                return false;

            if(dic[stack.Pop()] != c)
                return false;
        }

        return stack.Count == 0;
    }
}
