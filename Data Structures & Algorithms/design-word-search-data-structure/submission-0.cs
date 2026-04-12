public class WordDictionary {

    private readonly TreeNode _root = new();

    private class TreeNode
    {
        public TreeNode[] Children = new TreeNode[26];
        public bool Word = false;
    }

    public void AddWord(string word)
    {
        var cur = _root;

        foreach (char c in word)
        {
            var index = CharIndexCalculate(c);
            if (cur.Children[index] is null)
            {
                cur.Children[index] = new TreeNode();
            }

            cur = cur.Children[index];
        }

        cur.Word = true;
    }

    public bool Search(string word)
    {
        var cur = _root;

        return DFS(0, _root);

        bool DFS(int index, TreeNode node)
        {
            if(index == word.Length)
                return node.Word;
            
            var c =  word[index];
            if (c == '.')
            {
                foreach (var child in node.Children)
                {
                    if (child is not null && DFS(index + 1, child))
                        return true;
                }
                return false;
            }
            else
            {
                
                var i = CharIndexCalculate(c);
                if (node.Children[i] is null)
                {
                    return false;
                }
                
                return DFS(index+1, node.Children[i]);
            }
        }
    }

    private int CharIndexCalculate(char c) => c - 'a';
}
