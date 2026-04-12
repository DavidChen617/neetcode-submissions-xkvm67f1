public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        if(prerequisites.Length == 0){
            var arr = new int[numCourses];

            for(int i = 0; i < numCourses; ++i)
                arr[i] = i;

            return arr;
        }

        var adj = new Dictionary<int, List<int>>();
        var visit = new HashSet<int>();
        var cycle = new HashSet<int>();
        var result = new List<int>();

        foreach(var pre in prerequisites){
            var (a, b) = (pre[0], pre[1]);

            if(!adj.ContainsKey(a))
                adj.Add(a, new List<int>());
            
            adj[a].Add(b);
        }

        for(int i = 0; i < numCourses; ++i)
            if(!DFS(i))
                return new int[0];
        
        return result.ToArray();

        bool DFS(int node){
            if(cycle.Contains(node))
                return false;

            if(visit.Contains(node))
                return true;

            cycle.Add(node);

            if(adj.TryGetValue(node, out var neis))
                foreach(var nei in neis)
                    if(!DFS(nei))
                        return false;

            cycle.Remove(node);
            visit.Add(node);
            result.Add(node);

            return true;
        }
    }
}
