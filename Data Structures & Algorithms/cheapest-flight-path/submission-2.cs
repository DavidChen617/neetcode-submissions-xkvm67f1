public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        int[] prices = new int[n];
        Array.Fill(prices, int.MaxValue);
        prices[src] = 0;
        
        int count = 0;
        for(int i = 0; i <= k; ++i){
            var temp = (int[])prices.Clone();
    
            for(int f = 0 + count; f < flights.Length; ++f){
                var flight = flights[f];
                var source = flight[0];

                if(prices[source] == int.MaxValue)
                    continue;
                
                int destination = flight[1],
                    price = flight[2],
                    thePirce = prices[source] + price;
                
                if(thePirce < temp[destination]){
                    temp[destination] = thePirce;
                }
            }
            
            ++count;
            prices = temp;
        }

        return prices[dst] == int.MaxValue ? -1 : prices[dst];
    }
}
