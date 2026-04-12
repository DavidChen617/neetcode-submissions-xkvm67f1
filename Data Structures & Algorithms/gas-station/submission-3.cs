public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
         if (gas.Sum() - cost.Sum() < 0)
            return -1;
        
        int total = 0,
            index = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            total += gas[i] - cost[i];
            if (total < 0)
            {
                total = 0;
                index = i + 1;
            }
        }
        
        return index;
    }
}
