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
        if(pairs.Count == 0)
            return result;
       
        result.Add(new List<Pair>(pairs));
        for(int i = 1; i < pairs.Count; ++i){
           
            int j = i - 1;
            while(j>=0 && pairs[j+1].Key < pairs[j].Key){
                var temp = pairs[j];
                pairs[j] = pairs[j + 1];
                pairs[j + 1] = temp;
                --j;
            }
            result.Add(new List<Pair>(pairs));
        }

        return result;
    }
}
