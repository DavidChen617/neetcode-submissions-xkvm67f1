public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        DFS(0, 0, string.Empty);
        
        return result;

        void DFS(int openN, int closeN, string stack){
            if(openN == n && openN == closeN){
                result.Add(stack);
                return;
            }
            if(openN < n)
               DFS(openN + 1, closeN, stack + '(');
            
            if(closeN < openN)
               DFS(openN, closeN + 1, stack + ')');
        }
    }
}
