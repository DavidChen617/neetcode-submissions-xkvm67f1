public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
       
        for (int i = 0; i < s.Length; ++i) {
            var c = s[i];

            if (c == '[' || c == '{' || c == '(') {
                stack.Push(c);
                continue;
            }

            if(stack.Count < 1)
                return false;

            if (c == ']') {
                if (stack.Pop() != '[')
                    return false;
            } 
            else if (c == '}') {
                if (stack.Pop() != '{')
                    return false;
            } 
            else {
                if (stack.Pop() != '(')
                    return false;
            }
        }
        
        if(stack.Count != 0)
            return false;

        return true;
    }
}
