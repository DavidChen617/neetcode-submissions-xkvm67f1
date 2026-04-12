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
        
        if (curr == null)
        {
            _maps[index] = new Pair(key, value);
            IncreaseSize();
            
            return;
        }

        Pair prev = null;
        while (curr is not null)
        {
            if (curr.Key == key)
            {
                curr.Value = value;
                return;
            }
            prev = curr;
            curr = curr.Next;
        }
        prev.Next = new Pair(key, value);
        IncreaseSize();
    }

    public int Get(int key) {
        var index = Hash(key);
        var curr = _maps[index];
        
        while (curr is not null)
        {
            if(curr.Key == key)
                return curr.Value;
            
            curr = curr.Next;
        }

        return -1;
    }

    public bool Remove(int key) {
        var index = Hash(key);
        
        if(_maps[index] is null)
            return false;
        
        var curr = _maps[index];
        Pair prev = null;
        
        while (curr is not null)
        {
            if (curr.Key == key)
            {
                if(prev is null)
                    _maps[index] = curr.Next;
                else
                {
                    prev.Next = curr.Next;
                }
                --_size;
                return true;
            }
            prev = curr;
            curr = curr.Next;
        }

        return false;
    }

    public int GetSize()
    {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }

    public void Resize()
    {
        
        var newCapacity = _capacity * 2;
        var newMaps = new Pair[newCapacity];
        
        foreach (var pair in _maps)
        {
            var curr = pair;
            while (curr is not null)
            {
                var newIndex = Hash(curr.Key);
                var next = curr.Next;
                curr.Next = newMaps[newIndex];
                newMaps[newIndex] = curr;
                curr = next;
            }
        }
        
        _capacity = newCapacity;
        _maps = newMaps;
    }

    private int Hash(int key) => key % _capacity;
    
    private void IncreaseSize()
    {
        _size++;
        if ((double)_size / _capacity >= 0.5)
            Resize();
    }
}
