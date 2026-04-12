public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adj = new Dictionary<int, List<int>>();

        for(int i = 0; i < numCourses; ++i)
            adj.Add(i, new List<int>());

        foreach(var pre in prerequisites){
            adj[pre[1]].Add(pre[0]);
        }

        var state = new int[numCourses];

        for(int i = 0; i < numCourses; ++i){
            if(state[i] == 0)
                if(!DFS(i))
                    return false;
        }

        return true;

        bool DFS(int node){
        if(state[node] == 1)
            return false;
            
        if(state[node] == 2)
            return true;

        state[node] = 1;

        foreach(var nei in adj[node])
            if(!DFS(nei))
                return false;
        
        state[node] = 2;

        return true;
    }
}
}