public class LinkedList {

    class Node{
        public Node Next;
        public int Val;
        public Node(int val, Node node = null){
            Val = val;
            Next = node;
        }
    }

    private Node dummy;
    public LinkedList() {
        dummy = new Node(0);
    }

    public int Get(int index) {

        var curr = dummy.Next;
        while(index > 0 && curr != null){
            curr = curr.Next;
            --index;
        }
        return curr?.Val ?? -1;
    }

    public void InsertHead(int val) {
         var curr = dummy.Next;
         var newNode = new Node(val);
         newNode.Next = curr;
         dummy.Next = newNode;
    }

    public void InsertTail(int val) {
         var curr = dummy;
         while(curr.Next!=null)
            curr = curr.Next;
         var newNode = new Node(val);
         curr.Next = newNode;
    }

    public bool Remove(int index) {
       var curr = dummy;

       while(index > 0 && curr != null){
        curr = curr.Next;
        --index;
       }
       if(index > 0)
          return false;
       if(curr?.Next is null)
        return false;
       curr.Next = curr.Next?.Next ?? null;
       return true;
    }

    public List<int> GetValues() {
        var result = new List<int>();
        var curr = dummy.Next;
        while(curr!=null){
            result.Add(curr.Val);
            curr = curr.Next;
        }
        return result;
    }
}