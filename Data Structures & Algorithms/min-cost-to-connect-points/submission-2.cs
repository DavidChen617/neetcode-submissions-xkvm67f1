public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int N = points.Length;

        int res = 0;
        var neis = new PriorityQueue<int, int>();
        neis.Enqueue(0, 0);
        var set = new HashSet<int>();

        while(neis.Count > 0){
            _ = neis.TryDequeue(out var node, out var cost);
            
            if(!set.Add(node))
                continue;

            res += cost;

            for(int j = 0; j < N; ++j){
                if(set.Contains(j))
                    continue;
    
                int dist = Math.Abs(points[node][0] - points[j][0]) + 
                    Math.Abs(points[node][1] - points[j][1]);

                neis.Enqueue(j, dist);
            }
        }

        return res;
    }
}
