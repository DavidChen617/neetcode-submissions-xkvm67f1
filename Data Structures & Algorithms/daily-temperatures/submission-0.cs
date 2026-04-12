public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        var result = new int[n];

        for(int i = 0; i < n; ++i){
            for(int j = i + 1; j < n; ++j){
                if(temperatures[j] > temperatures[i]){
                    result[i] = j - i;
                    break;
                }
            }
        }

        return result;
    }
}
