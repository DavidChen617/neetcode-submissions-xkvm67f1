public class Solution {
    public bool ValidTree(int n, int[][] edges)
    {
        if (edges.Length != n-1)
            return false;
        
        var adj = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < n; ++i)
            adj[i] = new List<int>();
        
        for (int i = 0; i < edges.Length; i++)
        {
            var v = edges[i];
            var (key, value) = (v[0], v[1]);
    
            adj[key].Add(value);
            adj[value].Add(key);
        }

        var visted = new HashSet<int>();

        bool DFS(int cur, int prev)
        {
            if(visted.Contains(cur)) 
                return false;
            
            visted.Add(cur);
            
            foreach (var nei in adj[cur])
            {
                if(nei == prev)
                    continue;
                
                if(!DFS(nei, cur))
                    return false;
            }
            
            return true;
        }

        if(!DFS(0, -1))
            return false;

        return visted.Count == n;
    }
}
