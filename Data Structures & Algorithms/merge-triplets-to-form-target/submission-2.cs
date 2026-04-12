public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        var row = triplets.Length;
        var result = new int[3];
        
        for (int i = 0; i < row; i++)
        {
            if(triplets[i][0] > target[0] ||
               triplets[i][1] > target[1] ||
               triplets[i][2] > target[2])
                continue;
            
            result[0] = Math.Max(result[0], triplets[i][0]);
            result[1] = Math.Max(result[1], triplets[i][1]);
            result[2] = Math.Max(result[2], triplets[i][2]);
        }
        
        
        return result[0] == target[0] && result[1] == target[1] && result[2] == target[2];
    }
}
