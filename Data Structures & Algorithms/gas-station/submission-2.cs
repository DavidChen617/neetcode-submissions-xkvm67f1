public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        
        for (int start = 0; start < n; start++)
        {
            var tank = gas[start] - cost[start];
            if (tank < 0)
                continue;
            
            int cycle = (start + 1) % n;
            while (cycle != start)
            {
                tank += gas[cycle] - cost[cycle];
                if(tank < 0)
                    break;
                
                cycle = (cycle + 1) % n;
            }

            if (cycle == start)
            {
                return start;
            }
        }

        return -1;
    }
}
