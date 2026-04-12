// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) {

        MyMergeSort(pairs, 0, pairs.Count-1);
        return pairs;
    }
    private List<Pair> MyMergeSort(List<Pair> pairs, int l, int r){

        if(l >= r)
            return pairs;
        int m = (l + r) / 2;
        MyMergeSort(pairs, 0, m);
        MyMergeSort(pairs, m+1, r);
        Sort(pairs, l, m, r);
        return pairs;
    } 
     private List<Pair> Sort(List<Pair> pairs, int l, int m,int r){

        int leftLen = m - l + 1;
        int rightLen = r - m;
        var leftTemp = new List<Pair>();
        var rightTemp = new List<Pair>();

        for(var left = 0; left < leftLen; ++left)
            leftTemp.Add(pairs[l + left]);

        for(var right = 0; right < rightLen; ++right)
            rightTemp.Add(pairs[m + 1 + right]);

        int i = 0, j = 0, k = l;
        while(i < leftLen && j < rightLen)
            if(leftTemp[i].Key <= rightTemp[j].Key)
                pairs[k++] = leftTemp[i++];
            else
                pairs[k++] = rightTemp[j++];

        while(i < leftLen)
            pairs[k++] = leftTemp[i++];
        
        while(j < rightLen)
            pairs[k++] = rightTemp[j++];
            
        return pairs;
    }
}
