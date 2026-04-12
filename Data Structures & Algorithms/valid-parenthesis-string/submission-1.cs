public class Solution {
    public bool CheckValidString(string s) {
        int min = 0, max = 0;
        
        for(int i = 0; i < s.Length; ++i){
            if(s[i] == '('){
                 ++min;
                 ++max;
            }
            else if(s[i] == ')'){
                min = Math.Max(0, min - 1);
                --max;
                if(max < 0)
                    return false;
            }
            else{
                min = Math.Max(0, min - 1);
                ++max;
            }
        }

        return min == 0;
    }
}
