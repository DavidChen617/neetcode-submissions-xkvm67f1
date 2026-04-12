public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length != n - 1)
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
        var q = new Queue<(int node, int parent)>();

        if(!BFS(0))
            return false;

        for(int i = 0; i < n; ++i)
            if(!visted[i])
                return false;

        return true;

        bool BFS(int node){
            if(visted[node])
                return false;

            visted[node] = true;

            q.Enqueue((node, -1));

            while(q.Count > 0){
                var (cur, parent) = q.Dequeue();
                foreach(var nei in adj[cur]){
                    if(nei == parent)
                        continue;

                    if(visted[nei])
                        return false;

                    visted[nei] = true;
                    q.Enqueue((nei, cur));
                }
            }
        
            return true;
        }
    }
}
