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
        var q = new Queue<int>();

        for(int i = 0; i < n; ++i)
            if(!visted[i]){
                BFS(i);
                ++result;
            }
    
        return result;

        void BFS(int node){
            q.Enqueue(node);
            visted[node] = true;

            while(q.Count > 0){
                var cur = q.Dequeue();

                foreach(int nei in adj[cur])
                    if(!visted[nei]){
                        visted[nei] = true;
                        q.Enqueue(nei);
                    }
            }
        }
    }
}
