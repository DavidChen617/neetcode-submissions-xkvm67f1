public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        
        for (int i = 0; i < n; i++)
        {
            var tank = gas[i] - cost[i];
            if (tank < 0)
                continue;
            int cycle = (i + 1) % n;

            while (cycle != i)
            {
                tank += gas[cycle] - cost[cycle];
                if(tank < 0)
                    break;
                cycle = (cycle + 1) % n;
            }

            if (cycle == i)
            {
                return i;
            }
        }

        return -1;
    }
}
