public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var visited = new HashSet<int>();
        var preMap = new Dictionary<int, List<int>>();
        
        for (int i = 0; i < numCourses; ++i)
            preMap[i] = new List<int>();
        
        foreach (var pre in prerequisites)
        {
            var (key, value) = (pre[0], pre[1]);
            preMap[key].Add(value);
        }

        for (int i = 0; i < numCourses; i++)
            if(!DFS(i))
                return false;
        
        return true;
        
        bool DFS(int cur)
        {
            if(visited.Contains(cur))
                return false;
            
            if(!preMap[cur].Any())
                return true;
            
            visited.Add(cur);
            
            foreach (var pre in preMap[cur])
               if(!DFS(pre)) 
                   return false;
            
            visited.Remove(cur);
            preMap[cur].Clear();
            return true;
        }
    }
}
