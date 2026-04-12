public class Graph {

    private Dictionary<int, HashSet<int>> adjacencyList = new ();

    public Graph() {
    
    }

    public void AddEdge(int src, int dst) {
        foreach (var v in new []{src, dst})
            if(!adjacencyList.ContainsKey(v))
                adjacencyList.Add(v, new HashSet<int>());
        
        adjacencyList[src].Add(dst);
    }

    public bool RemoveEdge(int src, int dst) {
        if(!adjacencyList.ContainsKey(src))
            return false;
        if(!adjacencyList[src].Contains(dst))
            return false;
        adjacencyList[src].Remove(dst);
        
       return true;
    }

    public bool HasPath(int src, int dst)
    {
        var visited = new HashSet<int>();
        return DFS(src);

        bool DFS(int key)
        {
            if (key == dst)
                return true;
            
            visited.Add(key);
            
            if(!adjacencyList.TryGetValue(key, out var sets))
                return false;
            
            foreach (var neighbor in sets)
                if (!visited.Contains(neighbor))
                    if(DFS(neighbor))
                        return true;
            
            return false;
        }
    }
}
