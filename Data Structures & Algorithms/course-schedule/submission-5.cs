public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(prerequisites.Length == 0)
            return true;
            
        var adj = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < numCourses; ++i)
            adj.Add(i, new List<int>());
        
        foreach(var pre in prerequisites){
            var (k, v) = (pre[0], pre[1]);
            adj[v].Add(k);
        }
        
        // 0 = not viste, 1 = visting, 2 = done
        var state = new int[numCourses];

        for(int i = 0; i < numCourses; ++i){
            if(state[i] == 0){
                if(!DFS(i))
                    return false;
            }
        }

        return true;

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

            return true;
        }
    }
}










