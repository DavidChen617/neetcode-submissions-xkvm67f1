public class Solution {
    public bool ValidTree(int n, int[][] edges)
    {
        if(edges.Length != n-1)
            return false;

        var adj = new Dictionary<int, List<int>>();

        for(int i = 0; i < n; ++i)
            adj[i] = new List<int>();

        foreach(var edg in edges){
            var(key, value) = (edg[0], edg[1]);
            adj[key].Add(value);
            adj[value].Add(key);
        }

        var visted = new HashSet<int>();

        if(!DFS(0, -1))
            return false;

        return visted.Count == n;

        bool DFS(int curNode, int prevNode){

            if(visted.Contains(curNode))
                return false;

            visted.Add(curNode);

            foreach(var nei in adj[curNode]){
                if(nei == prevNode)
                    continue;

                if(!DFS(nei, curNode))
                    return false;
            }

            return true;
        }
    }
}
