public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
            
        var sCharArr = s.ToCharArray();
        var tCharArr = t.ToCharArray();

        Array.Sort(sCharArr);
        Array.Sort(tCharArr);

        for(int i = 0; i < sCharArr.Length; ++i)
            if(sCharArr[i] != tCharArr[i])
                return false;
        
        return true;
    }
}
