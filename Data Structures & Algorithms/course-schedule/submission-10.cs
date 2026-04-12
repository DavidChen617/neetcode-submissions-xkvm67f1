public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adj = new Dictionary<int, List<int>>();
        var visted = new HashSet<int>();

        for(var i = 0; i < numCourses; ++i)
            adj.Add(i, new List<int>());

        foreach(var pre in prerequisites){
            var (a, b) = (pre[0], pre[1]);
            adj[a].Add(b);
        }

        for(int i = 0; i < numCourses; ++i)
            if(!DFS(i))
                return false;

        return true;

        bool DFS(int node){
            if(visted.Contains(node))
                return false;

            if(adj[node].Count == 0)
                return true;

            visted.Add(node);

            foreach(var nei in adj[node])
                if(!DFS(nei))
                    return false;
            
            visted.Remove(node);
            adj[node].Clear();

            return true;
        }
    }
}

