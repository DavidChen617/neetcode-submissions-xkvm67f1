public class Solution {
    public List<List<string>> Partition(string s)
    {
        var result = new List<List<string>>();
        var part = new List<string>();
        DFS(0, 0);

        return result;

        void DFS(int l, int r)
        {
            if (r >= s.Length)
            {
                if (l == s.Length)
                    result.Add(new(part));
                return;
            }

            if (IsPali(l, r))
            {
                part.Add(s.Substring(l, r - l + 1));
                DFS(r+1, r + 1);
                part.RemoveAt(part.Count - 1);
            }
            
            DFS(l, r + 1);
        }
        
        bool IsPali(int l, int r)
        {
            while (l < r)
            {
                if(s[l] != s[r])
                    return false;

                ++l;
                --r;
            }
            
            return true;
        }
    }
}
