public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        for(int i = 0; i < tokens.Length; ++i){
            var c = tokens[i];
            if(int.TryParse(c, out var v)){
                stack.Push(int.Parse(c));
                continue;
            }

            int b = stack.Pop(),
                a = stack.Pop();

            if(c == "+"){
                stack.Push(b + a);
            }
            else if(c == "-"){
                stack.Push(a - b);
            }
            else if(c == "*"){
                stack.Push(a * b);
            }
            else{
                stack.Push(a / b);
            }
        }

        return stack.Pop();
    }
}
