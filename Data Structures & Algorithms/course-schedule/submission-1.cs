public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var prereq = new Dictionary<int, List<int>>();

        foreach(var pre in prerequisites){
            var(key, value) = (pre[0], pre[1]);

            if(!prereq.ContainsKey(key))
                prereq[key] = new List<int>();
            
            prereq[key].Add(value);
        }

        var cycle = new HashSet<int>();
        var visted = new HashSet<int>();

        for(int i = 0; i < numCourses; ++i)
            if(!DFS(i))
                return false;        

        return true;

        bool DFS(int curse){
            if(cycle.Contains(curse))
                return false;

            if(visted.Contains(curse))
                return true;
            
            cycle.Add(curse);

            if(prereq.TryGetValue(curse, out var curses))
                foreach(var cu in curses)
                    if(!DFS(cu))
                        return false;

            cycle.Remove(curse);
            visted.Add(curse);

            return true;
        }   
    }
}
