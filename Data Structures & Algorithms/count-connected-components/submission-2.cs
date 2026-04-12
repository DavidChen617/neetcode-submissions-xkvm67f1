public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var adj = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < n; ++i)
            adj.Add(i, new List<int>());
        
        foreach(var edg in edges){
            var(k, v) = (edg[0], edg[1]);
            adj[k].Add(v);
            adj[v].Add(k);
        }

        var visted = new bool[n];
        var result = 0;

        for(int i = 0; i < n; ++i){
            if(!visted[i]){
                DFS(i);
                ++result;
            }
        }

        return result;

        void DFS(int node){
            visted[node] = true;

            foreach(int nei in adj[node]){
                if(!visted[nei]){
                    DFS(nei);
                }
            }
        }
    }
}
