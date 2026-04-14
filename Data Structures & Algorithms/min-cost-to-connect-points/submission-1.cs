public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int N = points.Length;
        var adj = new Dictionary<int, List<(int node, int dist)>>();

        for(int i = 0; i < N; ++i){
            (int x1, int y1) = (points[i][0], points[i][1]);
            for(int j = i + 1; j < N; ++j){
                (int x2, int y2) = (points[j][0], points[j][1]);
                int dist = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);

                if(!adj.ContainsKey(i))
                    adj[i] = new();
                adj[i].Add((j, dist));

                if(!adj.ContainsKey(j))
                    adj[j] = new();
                
                adj[j].Add((i, dist));
            }
        }

        int res = 0;
        var neis = new PriorityQueue<int, int>();
        neis.Enqueue(0, 0);
        var set = new HashSet<int>();

        while(neis.Count > 0){
            _ = neis.TryDequeue (out var node, out var cost);
            if(!set.Add(node))
                continue;
            res += cost;

            if(adj.TryGetValue(node, out var value)){
                for(int i = 0; i < value.Count; ++i){
                    var v = value[i];
                    if(!set.Contains(v.node)){
                        neis.Enqueue(v.node, v.dist);
                    }
                }
            }
        }

        return res;
    }
}
