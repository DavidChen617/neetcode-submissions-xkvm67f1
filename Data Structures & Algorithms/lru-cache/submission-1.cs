public class LRUCache
{
    private class Node
    {
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public int Key { get; set; }
        public int Value { get; set; }

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    private Dictionary<int, Node> _cache;
    private int _capacity;
    private Node left;
    private Node right;
    
    public LRUCache(int capacity) {
        _capacity = capacity;
        _cache = new Dictionary<int, Node>(_capacity + 2);
        left = new Node(0, 0);
        right = new Node(0, 0);
        left.Next = right;
        right.Prev = left;
    }
    
    public int Get(int key)
    {
        if (_cache.ContainsKey(key))
        {
            var node = _cache[key];
            Remove(node);
            Insert(node);
            
            return node.Value;
        }

        return -1;
    }

    private void Insert(Node node)
    {
        var prev = right.Prev;
        right.Prev = node;
        prev.Next = node;
        node.Next = right;
        node.Prev = prev;
    }

    private void Remove(Node node)
    {
        var prev = node.Prev;
        var next = node.Next;
        prev.Next = next;
        next.Prev = prev;
    }

    public void Put(int key, int value) {
        if (_cache.TryGetValue(key, out var node))
        {
            node.Value = value;
            Remove(node);
            Insert(node);
            return;
        }
        
        if (_cache.Count >= _capacity)
        {
            var lru = left.Next;
            Remove(lru);
            _cache.Remove(lru.Key);
        }
        
        var newNode = new Node(key, value);
        _cache[key] = newNode;
        Insert(newNode);
    }
}
