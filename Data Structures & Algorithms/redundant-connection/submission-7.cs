public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var adj = new Dictionary<int, List<int>>();
        int N = edges.Length;

        for(int i = 1; i <= N; ++i)
            adj.Add(i, new List<int>());

        foreach(var edg in edges){
            var (k, v) = (edg[0], edg[1]);
            adj[k].Add(v);
            adj[v].Add(k);
        }

        var visted = new bool[N+1];
        var cycle = new HashSet<int>();
        var cycleStart = -1;

        DFS(1, -1);

        for(int i = N - 1; i >=0; --i){
            var edg = edges[i];
            var(k, v) = (edg[0], edg[1]);

            if(cycle.Contains(k) && cycle.Contains(v))
                return new int[]{k, v};
        }

        return new int[0];

        bool DFS(int node, int paraent){
            if(visted[node]){
                cycleStart = node;
                return true;
            }
                
            visted[node] = true;

            foreach(var nei in adj[node]){
                if(nei == paraent)
                    continue;

                if(DFS(nei, node)){
                    if(cycleStart != -1)
                        cycle.Add(node);

                    if(node == cycleStart)
                        cycleStart = -1;

                    return true;
                }   
            }

            return false;
        }
    }
}
