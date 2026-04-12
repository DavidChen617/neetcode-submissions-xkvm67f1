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
        MergeSort(0, pairs.Count - 1);
        return pairs;
    
        void MergeSort(int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSort(l, m);
                MergeSort(m + 1, r);
                Merge(l, m, r);
            }
        }
    
        void Merge(int l, int m, int r)
        {
            var leftTemp = new Pair[m - l + 1];
            var rightTemp = new Pair[r - m];
            
            for (int i = 0; i < leftTemp.Length; ++i)
                leftTemp[i] = pairs[l + i];
            
            for (int i = 0; i < rightTemp.Length; ++i)
                rightTemp[i] = pairs[m + i + 1];
            
            int left = 0, right = 0, k = l;
            
            while (left < leftTemp.Length && right < rightTemp.Length)
            {
                if (leftTemp[left].Key > rightTemp[right].Key)
                {
                    pairs[k] = rightTemp[right]; 
                    ++right;
                    
                }
                else
                {
                   pairs[k] = leftTemp[left];
                    ++left;
                }

                ++k;
            }

            while (left < leftTemp.Length)
            {
                pairs[k] = leftTemp[left];
                ++left;
                ++k;
            }
            
            while (right < rightTemp.Length)
            {
                pairs[k] = rightTemp[right]; 
                ++right;
                ++k;
            }
        }
    }
}
