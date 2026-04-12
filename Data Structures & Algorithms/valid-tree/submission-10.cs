public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length != n-1)
            return false;

        var adj = new Dictionary<int, List<int>>();

        for(int i = 0; i < n; ++i)
            adj.Add(i, new List<int>());
        
        foreach(var edg in edges){
            var (k, v) = (edg[0], edg[1]);
            adj[k].Add(v);
            adj[v].Add(k);
        }
        
        var visted = new bool[n];
        
        if(!DFS(0, -1))
            return false;

        for(int i = 0; i < n; ++i)
            if(!visted[i])
                return false;

        return true;

        bool DFS(int node, int paraent){
            if(visted[node])
                return false;

            visted[node] = true;

            foreach(var nei in adj[node]){
                if(nei == paraent)
                    continue;

                if(!DFS(nei, node))
                    return false;
            }

            return true;
        }
    }
}
