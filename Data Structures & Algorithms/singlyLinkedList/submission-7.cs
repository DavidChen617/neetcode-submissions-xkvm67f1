public class LinkedList {

    private class Node{
        public int val;
        public Node next;
        public Node(int val, Node next = null ){
            this.val = val;
            this.next = next;
        }
    }

    private Node tail;
    private Node dummy;

    public LinkedList() {
        dummy = new Node(0);
        tail = dummy;
    }

    public int Get(int index) {
        var curr = dummy.next;
        while (index > 0) {
        if (curr == null)
            return -1;
        curr = curr.next;
        --index;
        }
        return curr == null ? -1 : curr.val;
    }

    public void InsertHead(int val) {
        var node = new Node(val);
        node.next = dummy.next;

        if(tail == dummy)
            tail = node;

        dummy.next = node;
    }

    public void InsertTail(int val) {
        var node = new Node(val);
        if(tail == dummy){
            dummy.next = node;
            tail = node;
            return;
        }
          
        tail.next = node;
        tail = tail.next;
    }

    public bool Remove(int index) {
        var curr = dummy;
        while(index > 0){
            if(curr.next == null)
                return false;
            curr = curr.next;
            --index;
        }

        if(curr.next == null)
            return false;

        if(curr.next == tail)
            tail = curr;
        
        curr.next = curr.next.next;

        return true;
    }

    public List<int> GetValues() {
        var res = new List<int>();
        var curr = dummy?.next;
        while(curr!=null){
            res.Add(curr.val);
            curr = curr.next;
        }

        return res;
    }
}