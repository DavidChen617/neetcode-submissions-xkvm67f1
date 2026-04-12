class SinglyNode
{
    public SinglyNode Next { get; set; }
    public int Value { get; set; }

    public SinglyNode(int value, SinglyNode next = null)
    {
        Value = value;
        Next = next;
    }
}

public class LinkedList {
    private readonly SinglyNode _head = new SinglyNode(0);
    private int _size = 0;
    
    public LinkedList() {
    }

    public int Get(int index)
    {
        if (index < 0 || index >= _size)
            return -1;
        
        var curr = _head.Next;
        
        while (index > 0)
        {
            curr = curr.Next;
            --index;
        }
        
        return curr.Value;
    }

    public void InsertHead(int val) {
        var newNode = new SinglyNode(val, _head.Next);
        _head.Next = newNode;
        _size++;
    }

    public void InsertTail(int val) {
        var curr = _head;
      
        while(curr.Next is not null)
            curr = curr.Next;
        
        var newNode = new SinglyNode(val);
        curr.Next = newNode;
        ++_size;
    }

    public bool Remove(int index) {
        if (index < 0 || index >= _size) 
            return false;
        
        var curr = _head.Next;
        SinglyNode prev = _head;
        
        while (index > 0)
        {
            prev = curr;
            curr = curr.Next;
            --index;
        }
        
        prev.Next = curr.Next;
        --_size;
        return true;
    }

    public List<int> GetValues() {
        var result = new List<int>();
        var curr = _head.Next;
       
        while (curr is not null)
        {
            result.Add(curr.Value);
            curr = curr.Next;
        }

        return result;
    }
}
