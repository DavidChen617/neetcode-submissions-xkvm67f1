public class Solution {
    public bool IsValid(string s) {
        // 準備映射表
        Dictionary<char, char> dic = new (){
            { ']', '['},
            { '}', '{'},
            { ')', '('},
        };
        // 準備 stack 資料結構
        var stack = new Stack<char>();

        foreach(var c in s){
            // 判斷當前字元是否包含在映射表的 key 內, 如果不包含則代表為右括弧
            if(!dic.ContainsKey(c))
                stack.Push(c);
            else {
                // 先判斷 stack 是否有值與當前映射 value 與 stack peek 出來的是否相等
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
