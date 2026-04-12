public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var pair = new (int posi, int spee)[n];

        for(int i = 0; i < n; ++i)
            pair[i] = (position[i], speed[i]);

        Array.Sort(pair, (a, b) => b.posi.CompareTo(a.posi));

        double last_time = -1;
        int fleet = 0;

        for(int i = 0; i < n; ++i){
            double t = (double)(target - pair[i].posi) / pair[i].spee;
            if(t > last_time){
                fleet++;
                last_time = t;
            }
        }

        return fleet;
    }
}
