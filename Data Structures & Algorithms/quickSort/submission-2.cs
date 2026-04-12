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
        QuickSort(0, pairs.Count -1);
        return pairs;

        void QuickSort(int s, int e){
            if(s >= e)
                return;
            
            var pivot = pairs[e];
            var left = s;

            for(int i =s; i < e; ++i){
                if(pairs[i].Key < pivot.Key){
                    var temp = pairs[left];
                    pairs[left] = pairs[i];
                    pairs[i] = temp;
                    ++left;
                }
            }

            pairs[e] = pairs[left];
            pairs[left] = pivot;

            QuickSort(s, left - 1);
            QuickSort(left + 1, e);
        }
    }
}
