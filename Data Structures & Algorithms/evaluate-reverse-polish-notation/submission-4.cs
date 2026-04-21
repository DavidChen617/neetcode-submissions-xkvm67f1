public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        var operate = new Dictionary<string, Action<int ,int>>
        {
            {"+", (a, b) => { stack.Push(a + b);}},
            {"-", (a, b) => { stack.Push(a - b);}},
            {"*", (a, b) => { stack.Push(a * b);}},
            {"/", (a, b) => { stack.Push(a / b);}},
        };
     
        for(int i = 0; i < tokens.Length; ++i){
            var c = tokens[i];
            if(int.TryParse(c, out var v)){
                stack.Push(int.Parse(c));
                continue;
            }

            int b = stack.Pop(),
                a = stack.Pop();
            
            operate[c](a, b);
        }

        return stack.Pop();
    }
}
