public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        var prices = new int[n];
        Array.Fill(prices, int.MaxValue);
        prices[src] = 0;

        for(int i = 0; i <= k; ++i){
            var temp = (int[])prices.Clone();

            for(int f = 0; f < flights.Length; ++f){
                var flight = flights[f];
                var start = flight[0];

                if(prices[start] == int.MaxValue)
                    continue;
                
                int d = flight[1], p = flight[2],
                    thePrice = prices[start] + p;
                
                if(thePrice < temp[d]){
                    temp[d] = thePrice;
                }
            }
            prices = temp;
        }

        return prices[dst] == int.MaxValue ? -1 : prices[dst];
    }
}
/**
Input: n = 4, 
flights = [[0,1,200],[1,2,100],[1,3,300],[2,3,100]], 

src = 0, dst = 3, k = 1
i = 1

prices = [
   0, 200, max, max
]

temp = [
    0, 200, 300, 500
]

s = 2, d = 3, p = 300

*/
