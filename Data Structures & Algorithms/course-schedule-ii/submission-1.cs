public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        var adjacency = new List<List<int>>();
        var indegree = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
            adjacency.Add(new List<int>());

        for (int i = 0; i < prerequisites.Length; i++)
        {
            var pre = prerequisites[i];
            var (key, value) = (pre[0], pre[1]);
            indegree[key]++;
            adjacency[value].Add(key);
        }

        var output = new List<int>();

        for (int i = 0; i < numCourses; i++)
            if (indegree[i] == 0)
                DFS(i);

        if (output.Count != numCourses)
            return Array.Empty<int>();

        return output.ToArray();

        void DFS(int i)
        {
            output.Add(i);
            --indegree[i];
            foreach (var nei in adjacency[i])
            {
                --indegree[nei];
                if(indegree[nei] == 0)
                    DFS(nei);
            }
        }
    }
}