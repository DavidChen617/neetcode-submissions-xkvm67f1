// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
        QuickSort(0, pairs.Count - 1);
        return pairs;

        void QuickSort(int left, int right){
            if(left >= right)
                return;
            
            var pivot = pairs[right];
            var parittionIndex = left;

            for(int scan = left; scan < right; ++scan){
                if(pairs[scan].Key < pivot.Key){
                    Swap(scan, parittionIndex);
                    ++parittionIndex;
                }
            }
            
            Swap(parittionIndex, right);

            QuickSort(parittionIndex + 1, right);
            QuickSort(left, parittionIndex -1);
        }

        void Swap(int l1, int r1){
            (pairs[l1], pairs[r1]) = (pairs[r1], pairs[l1]);
        }
    }
}
