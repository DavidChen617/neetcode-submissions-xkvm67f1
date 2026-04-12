public class WordDictionary {
    private readonly TreeNode _root = new();

    public void AddWord(string word) {
        var cur = _root;

        foreach(var c in word){
            var index = CalculateCharIndex(c);

            if(cur.Children[index] is null)
                cur.Children[index] = new();

            cur = cur.Children[index];
        }

        cur.Word = true;
    }
    
    public bool Search(string word) {
        return DFS(0, _root);

        bool DFS(int index, TreeNode cur){
            if(index == word.Length)
                return cur.Word;

            var c = word[index];
            var charIdx = CalculateCharIndex(c);

            if(c == '.'){
                foreach(var chi in cur.Children){
                    if(chi is not null && DFS(index + 1, chi))
                        return true;
                }

                return false;
            }
            
            if(cur.Children[charIdx] is null)
                return false;
    
            return DFS(index + 1, cur.Children[charIdx]);
        }
    }

    private int CalculateCharIndex(char c) => c - 'a';

    private class TreeNode{
        public readonly TreeNode[] Children = new TreeNode[26];
        public bool Word = false;
    }
}
