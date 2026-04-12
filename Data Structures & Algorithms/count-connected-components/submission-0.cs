public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var adj = new List<List<int>>();

        for(int i = 0; i < n; ++i)
            adj.Add(new List<int>());
        
        foreach(var edg in edges){
            var(key, value) = (edg[0], edg[1]);
            adj[key].Add(value);
            adj[value].Add(key);
        }

        var visted = new bool[n];
        var res = 0;

        for(int node = 0; node < n; ++node)
            if(!visted[node]){
                DFS(node);
                ++res;
            }
        
        return res;
        
        void DFS(int node){
            visted[node] = true;
            foreach(var nei in adj[node])
                if(!visted[nei])
                    DFS(nei);
        }
    }
}
        
