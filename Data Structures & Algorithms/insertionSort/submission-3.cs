// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        var result = new List<List<Pair>>();
        if(pairs.Count < 1)
            return result;

        var clone = new List<Pair>(pairs);
        result.Add(clone);
        
        for(var i = 1; i < pairs.Count; ++i){
            int j = i-1;
            while(j>=0 && pairs[j].Key > pairs[j+1].Key){
                if(pairs[j].Key > pairs[j+1].Key){
                    var temp = pairs[j];
                    pairs[j] = pairs[j+1];
                    pairs[j+1] = temp;
                }
                --j;
            }
            clone = new List<Pair>(pairs);
            result.Add(clone);
        }

        return result;
    }
}
