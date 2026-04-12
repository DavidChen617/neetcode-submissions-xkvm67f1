public class Solution {
    Func<int, int, string, int> handler = (int op1, int op2, string operand) =>
    {
        switch (operand)
        {
            case "+":
                return op1 + op2;
            case "-":
                return op1 - op2;
            case "*":
                return op1 * op2;
            case "/":
                return op1 / op2;
            default:
                return 0;
        }
    };

    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach(var token in tokens){
            if(int.TryParse(token, out int num))
            {
                stack.Push(num);
                continue;
            }
            
            (int op2, int op1) = (stack.Pop(), stack.Pop());
            stack.Push(handler(op1, op2, token));
        }

        return stack.Pop();
    }
}
