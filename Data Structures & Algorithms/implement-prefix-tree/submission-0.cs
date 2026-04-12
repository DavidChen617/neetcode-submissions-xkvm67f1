public class PrefixTree {

    private class TreeNode
    {
        public TreeNode[] Children = new  TreeNode[26];
        public bool EndOfWord = false;
    }
    private readonly TreeNode _root = new ();
    
    public void Insert(string word)
    {
        var current = _root;
        foreach (var c in word)
        {
            var index = c - 'a';
            if (current.Children[index] is null)
            {
                current.Children[index] = new ();
            }
            
            current = current.Children[index];
        }

        current.EndOfWord = true;
    }

    public bool Search(string word)
    {
        var current = _root;
        
        foreach (var c in word)
        {
            if (current.Children[c - 'a'] is null)
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
            if (current.Children[c - 'a'] is null)
                return false;
            
            current = current.Children[c - 'a'];
        }
        
        return true;
    }
}
