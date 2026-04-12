public class Solution {
    private readonly Dictionary<char, string> _digitsToChar = new()
    {
      { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" },
      { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" },
    };
    public List<string> LetterCombinations(string digits) {
        var result = new List<string>();
        if(digits.Length == 0)
            return result;
        
        DFS(0, string.Empty);

        return result;
        
        void DFS(int i, string curStr)
        {
            if (curStr.Length == digits.Length)
            {
                result.Add(curStr);
                return;
            }

            foreach (var c in _digitsToChar.GetValueOrDefault(digits[i], string.Empty))
            {
                DFS(i+1, curStr + c);
            }
        }
    }
}
