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
        MyQuickSort(pairs, 0, pairs.Count-1);
        return pairs;
    }
    private void MyQuickSort(List<Pair> pairs, int s, int e) {
        if(s >= e)
            return;
        var privot = pairs[e];
        int left = s;
        for(var i = s; i < e; ++i){
            if(pairs[i].Key < privot.Key){
                var temp = pairs[i];
                pairs[i] = pairs[left];
                pairs[left] = temp;
                ++left;
            }
        }
        pairs[e] = pairs[left];
        pairs[left] = privot;
       
        MyQuickSort(pairs, s, left-1);
        MyQuickSort(pairs, left+1, e);
    }
}
