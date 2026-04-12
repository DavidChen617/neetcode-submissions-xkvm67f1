
public class WordDictionary
{
    private readonly TreeNode _root = new TreeNode();
    private readonly Func<char, int> _charIndexCalculator = c => c - 'a';

    public void AddWord(string word)
    {
        var cur = _root;

        foreach (var c in word)
        {
            var charIdx = _charIndexCalculator(c);

            if (cur.Children[charIdx] is null)
                cur.Children[charIdx] = new();

            cur = cur.Children[charIdx];
        }

        cur.Word = true;
    }

    public bool Search(string word)
    {
        return DFS(0, _root);

        bool DFS(int wordIndex, TreeNode cur)
        {
            if (wordIndex == word.Length)
                return cur.Word;

            var c = word[wordIndex];

            if (c == '.')
            {
                foreach (var child in cur.Children)
                {
                    if (child is not null && DFS(wordIndex + 1, child))
                        return true;
                }

                return false;
            }

            var charIdx = _charIndexCalculator(c);

            if (cur.Children[charIdx] is null)
                return false;

            return DFS(wordIndex + 1, cur.Children[charIdx]);
        }
    }

    private int CharIndexCalculate(char c) => c - 'a';

    private class TreeNode
    {
        public TreeNode[] Children { get; set; } = new TreeNode[26];
        public bool Word { get; set; } = false;
    }
}
