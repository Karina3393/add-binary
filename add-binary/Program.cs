using System.Text;

namespace add_binary
{

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0, i = a.Length - 1, j = b.Length - 1;

            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';
                result.Insert(0, sum % 2);
                carry = sum / 2;
            }

            if (carry > 0) result.Insert(0, carry);
            return result.ToString();
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            string a = "1010";
            string b = "1011";
            Console.WriteLine($"Результат: {solution.AddBinary(a, b)}"); 

            a = "0";
            b = "0";
            Console.WriteLine($"Результат: {solution.AddBinary(a, b)}"); 

            a = "111";
            b = "1";
            Console.WriteLine($"Результат: {solution.AddBinary(a, b)}"); 
        }
    }
}
