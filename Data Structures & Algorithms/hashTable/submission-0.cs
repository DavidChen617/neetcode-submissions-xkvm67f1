public class HashTable
{
    private class Pair
    {
        public int Key
        {
            get; 
            set;
        }

        public int Value
        {
            get;
            set;
        }

        public Pair? Next
        {
            get;
            set;
        }

        public Pair(int key, int value, Pair? next = null)
        {
            Key = key;
            Value = value;
            Next = next;
        }
    }

    private int _capacity;
    private int _size;
    private Pair[] _maps;
    
    public HashTable(int capacity) {
        _capacity = capacity;
        _maps = new Pair[_capacity];
        _size = 0;
    }

    public void Insert(int key, int value)
    {
        var index = Hash(key);
        var curr = _maps[index];
        
        if (curr is null)
        {
            _maps[index] = new Pair(key, value);
            _size++;
            
            if(_size >= _capacity / 2)
                Resize();
            
            return;
        }
        
        curr.Value = value;
    }

    public int Get(int key) {
        var index = Hash(key);
        var curr = _maps[index];
        
        if(curr is null)
            return -1;
        
        return curr.Value;
    }

    public bool Remove(int key) {
        var index = Hash(key);
        if(_maps[index] is null)
            return false;
        
        _maps[index] = null;
        --_size;
        
        return true;
    }

    public int GetSize()
    {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }

    public void Resize() {
        _capacity *= 2;
        var oldPairs = _maps;
        _maps = new Pair[_capacity];
        
        foreach (var pair in oldPairs)
        {
            if (pair is not null)
            {
                var index = Hash(pair.Key);
                _maps[index] = pair;
            }
            // var curr = pair;
            
            // while (curr is not null)
            // {
            //     var next = curr.Next;
            //     curr.Next = null;
            //     Insert(curr.Key, curr.Value);
            //     curr = next;
            // }
        }
    }

    private int Hash(int key)
    {
        var index = key.ToString().Sum(x => (int)x) % _capacity;
        
        return index;
    }
}
