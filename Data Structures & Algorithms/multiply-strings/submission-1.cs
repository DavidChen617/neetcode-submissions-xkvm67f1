public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0")
            return "0";

        int m = num1.Length,
            n = num2.Length;

        var res = new int[m + n];

        for (int i = m - 1; i >= 0; --i)
        {
            int n1 = num1[i] - '0';
            for (int j = n - 1; j >= 0; --j)
            {
                int n2 = num2[j] - '0',
                    mult = n1 * n2,
                    sum = res[i + j + 1] + mult;

                res[i + j + 1] = sum % 10;
                res[i + j] += sum / 10;
            }
        }
        
        var sb = new StringBuilder();

        for (int i = 0; i < res.Length; i++)
        {
            int num = res[i];
            
            if(!(sb.Length == 0 && num == 0))
                sb.Append(num);
        }
        
        return sb.Length == 0 ? "0" : sb.ToString();
    }
}