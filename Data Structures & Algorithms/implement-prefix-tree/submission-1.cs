public class PrefixTree {

   private class TreeNode
    {
        public TreeNode[] Children = new TreeNode[26];
        public bool EndOfWord = false;
    }

    private readonly TreeNode _root = new();

    public void Insert(string word)
    {
        var current = _root;
        foreach (var c in word)
        {
            if (current.Children[CharIndexCalculate(c)] is null)
            {
                current.Children[CharIndexCalculate(c)] = new();
            }

            current = current.Children[CharIndexCalculate(c)];
        }

        current.EndOfWord = true;
    }

    public bool Search(string word)
    {
        var current = _root;

        foreach (var c in word)
        {
            if (current.Children[CharIndexCalculate(c)] is null)
                return false;

            current = current.Children[c - 'a'];
        }

        return current.EndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var current = _root;

        foreach (var c in prefix)
        {
            if (current.Children[CharIndexCalculate(c)] is null)
                return false;

            current = current.Children[CharIndexCalculate(c)];
        }

        return true;
    }

    private int CharIndexCalculate(char c)
        => c - 'a';
}
