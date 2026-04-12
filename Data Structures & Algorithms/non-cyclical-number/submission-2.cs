public class Solution {
    public bool IsHappy(int n) {
        var seed = new HashSet<int>();

        while (n != 1)
        {
            if(!seed.Add(n))
                return false;
            
            var output = 0;
            while (n > 0)
            {
                var digit = n % 10;
                output += digit * digit;
                n /= 10;
            }
            n = output;
        }
        
        return true;
    }
}
