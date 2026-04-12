public class Solution {
    public int LastStoneWeight(int[] stones) {
        Heapify heap = new Heapify(stones);
        while(heap.Size > 1){
            var first = heap.Pop();
            var second = heap.Pop();
            var res = first - second;
            if(res >= 0)
                heap.Push(res);
        }

        return heap.First;
    }
}

class Heapify{
    private List<int> _heap = new List<int>(){0};

    public int Size {
         get => _heap.Count - 1;
    }
    public int First{
         get => _heap[1];
    }

    public Heapify(int[] arr){
        foreach(int i in arr){
            Push(i);
        }
    }

    public void Push(int val){
        _heap.Add(val);
        var count = _heap.Count - 1;

        while (count > 1 && _heap[count] > _heap[count / 2])
        {
            (_heap[count], _heap[count / 2]) =  (_heap[count / 2], _heap[count]);
            count = count / 2;
        }
    }

    public int Pop(){
        var val = _heap[1];
        _heap[1] = _heap[_heap.Count - 1];
        _heap.RemoveAt(_heap.Count - 1);
        int index = 1;

        while(index * 2 < _heap.Count){
            var leftChild = index * 2;
            var rightChild = index * 2 + 1;
            if(rightChild < _heap.Count && _heap[rightChild] > _heap[leftChild] && _heap[rightChild] > _heap[index]){
                (_heap[rightChild], _heap[index]) = (_heap[index], _heap[rightChild]);
                index = rightChild;
            }
            else if( _heap[leftChild] > _heap[index]){
                (_heap[leftChild], _heap[index]) = (_heap[index], _heap[leftChild]);
                index = leftChild;
            }
            else
            {
                break;
            }
        }
        return val;
    }
}
