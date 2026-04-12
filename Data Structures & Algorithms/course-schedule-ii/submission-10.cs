public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        if(prerequisites.Length == 0){
            var arr = new int[numCourses];

            for(int i = 0; i < numCourses; ++i)
                arr[i] = i;

            return arr;
        }
        
        var adj = new Dictionary<int, List<int>>();
        var visited = new HashSet<int>();
        var cycle = new HashSet<int>();

        foreach(var pre in prerequisites){
            var (a, b) = (pre[0], pre[1]);

            if(!adj.ContainsKey(a))
                adj[a] = new List<int>();

            adj[a].Add(b);
        }

        var result = new List<int>();

        for(int i = 0; i < numCourses; ++i)
            if(!DFS(i))
                return new int[0];

        return result.ToArray();

        bool DFS(int node){
            if(cycle.Contains(node))
                return false;

            if(visited.Contains(node))
                return true;

            cycle.Add(node);

            if(adj.ContainsKey(node))
                foreach(var nei in adj[node])
                    if(!DFS(nei))
                        return false;

            cycle.Remove(node);
            visited.Add(node);
            result.Add(node);

            return true;
        }
    }
}
