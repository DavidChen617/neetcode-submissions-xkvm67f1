public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        var prereq = new Dictionary<int, List<int>>();
        foreach (var req in prerequisites)
        {
            var (key, value) = (req[0], req[1]);
            if (!prereq.ContainsKey(key))
                prereq.Add(key, new List<int>());

            prereq[key].Add(value);
        }

        var output = new List<int>();
        var visited = new HashSet<int>();
        var cycle = new HashSet<int>();

        for (int curse = 0; curse < numCourses; ++curse)
            if (!DFS(curse))
                return Array.Empty<int>();

        return output.ToArray();

        bool DFS(int curse)
        {
            if(cycle.Contains(curse))
                return false;
            if(visited.Contains(curse))
                return true;
            
            cycle.Add(curse);
            
            if (prereq.TryGetValue(curse, out var request))
                foreach (var r in request)
                   if(!DFS(r)) 
                       return false;
            
            cycle.Remove(curse);
            visited.Add(curse);
            output.Add(curse);
            
            return true;
        }
    }
}