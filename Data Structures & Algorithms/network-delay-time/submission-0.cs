public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        var edges = new Dictionary<int, List<(int dist, int time)>>();
        for(int i = 0; i < times.Length; ++i){
            var time = times[i];
            
            if(!edges.ContainsKey(time[0]))
                edges[time[0]] = new List<(int dist, int time)>();
            edges[time[0]].Add((time[1], time[2]));
        }

        var pq = new PriorityQueue<int, int>(); // node, wight
        pq.Enqueue(k, 0);
        var dist = new Dictionary<int, int>();
        for(int i = 0; i <= n; ++i)
            dist[i] = int.MaxValue;

        dist[k] = 0;

        while(pq.Count > 0){

            if(pq.TryDequeue(out var node, out var minDest)){
                if(minDest > dist[node]){
                    continue;
                }

                if(edges.TryGetValue(node, out var value)){
                    for(int i = 0; i < value.Count; ++i){
                        var edge = value[i];
                        var next = edge.dist;
                        var weight = edge.time;
                        var newDist = weight + minDest;

                        if(newDist < dist[next]){
                            dist[next] = newDist;
                            pq.Enqueue(next, newDist);
                        }
                    }
                }
            }
        }

        int result = 0;

        for(int i = 1; i <= n; ++i){
            if(dist[i] == int.MaxValue)
                return -1;
            
            result = Math.Max(result, dist[i]);
        }

        return result;
    }
}