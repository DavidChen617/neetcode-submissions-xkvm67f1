public class Solution {
    private readonly Dictionary<char, string> _digitsToChar = new()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" },
    };

    public List<string> LetterCombinations(string digits)
    {
        var result = new List<string>();
        if(string.IsNullOrEmpty(digits))
            return result;

        DFS(0, string.Empty);
        
        return result;

        void DFS(int index, string letter)
        {
            if (letter.Length == digits.Length)
            {
                result.Add(letter);
                return;
            }

            foreach (var c in _digitsToChar.GetValueOrDefault(digits[index], string.Empty))
            {
                DFS(index + 1, letter + c);
            }
        }
    }
}
