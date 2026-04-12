public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var adj = new Dictionary<int, List<int>>();

        for(int i = 0; i < numCourses; ++i)
            adj.Add(i, new List<int>());
        
        foreach(var pre in prerequisites){
            var (a, b) = (pre[0], pre[1]);
            adj[a].Add(b);
        }

        // 0 = not visted, 1 = visting, 2 = done
        var state = new int[numCourses];
        var result = new HashSet<int>();

        for(int i = 0; i < numCourses; ++i){
            if(state[i] == 0){
                if(!DFS(i))
                    return new int[0];
            }
        }

        // result.Reverse();
        return result.ToArray();

        bool DFS(int node){
            if(state[node] == 1)
                return false;

            if(state[node] == 2)
                return true;
            
            state[node] = 1;

            foreach(var nei in adj[node]){
                if(!DFS(nei))
                    return false;
            }

            state[node] = 2;
            result.Add(node);

            return true;
        }
    }
}
