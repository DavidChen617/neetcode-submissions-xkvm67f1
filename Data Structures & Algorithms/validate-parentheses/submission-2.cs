public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> dic = new (){
            { ']', '['},
            { '}', '{'},
            { ')', '('},
        };
        var stack = new Stack<char>();

        foreach(var c in s){
            if(!dic.ContainsKey(c))
                stack.Push(c);
            else {
                if(stack.Count > 0 && dic[c] == stack.Peek()){
                    stack.Pop();
                }
                else 
                 return false;
            }
        }

        return stack.Count == 0;
    }
}
