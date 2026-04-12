public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var adj = new Dictionary<int, List<int>>();

        for(var i = 0; i < edges.Length; ++i){
            adj.Add(i+1, new List<int>());
        }

        foreach(var edg in edges){
            var (k, v) = (edg[0], edg[1]);
            adj[k].Add(v);
            adj[v].Add(k);

            var visted = new bool[edges.Length+1];

            if(DFS(k, -1, visted))
                return new int[]{k, v};
        }

        return new int[0];

        bool DFS(int node, int paraent, bool[] visted){
            if(visted[node])
                return true;

            visted[node] = true;

            foreach(var nei in adj[node]){
                if(nei == paraent)
                    continue;
                if(DFS(nei, node, visted))
                    return true;
            }

            return false;
        }
    }
}
