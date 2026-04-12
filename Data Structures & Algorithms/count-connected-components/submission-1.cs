public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var adj = new Dictionary<int, List<int>>();
        for(int i =0; i < n; ++i)
            adj.Add(i, new List<int>());

        foreach(var edg in edges){
            var(key, value) = (edg[0], edg[1]);
            adj[key].Add(value);
            adj[value].Add(key);
        }

        var viste = new bool[n];
        var res = 0;

        for(int node = 0; node < n; ++node)
            if(!viste[node]){
                DFS(node);
                ++res;
            }
            
        return res;

        void DFS(int node){
            viste[node] = true;
            foreach(var nei in adj[node])
                if(!viste[nei])
                    DFS(nei);
        }
    }
}
