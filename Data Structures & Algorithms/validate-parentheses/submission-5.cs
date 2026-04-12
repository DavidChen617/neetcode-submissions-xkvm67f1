public class Solution {
    public bool IsValid(string s) {
        var dic = new Dictionary<char, char>{
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        var sta = new Stack<char>();

        foreach(var c in s){
            if(dic.TryGetValue(c, out var value)){
                if(sta.Count > 0 && sta.Peek() == value){
                    sta.Pop();
                }else{
                    return false;
                }
            }else{
                sta.Push(c);
            }
        }

        return sta.Count == 0;
    }
}
