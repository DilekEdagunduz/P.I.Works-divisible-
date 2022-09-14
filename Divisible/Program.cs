using System;

namespace Divisible
{
    class Program
    {
        
        // by sum of its digits
        static String is_divisible(long input)
        {
            long temp = input;

            // sum of digits
            int sum = 0;
            while (input != 0)
            {
                int k = (int)input % 10;
                sum += k;
                input /= 10;
            }

            // check if sum of digits divides 
            if (temp % sum == 0)
                return "YES";

            return "NO";
        }

        public static void Main()
        {
            long input = 75;
            Console.WriteLine(is_divisible(input));
        }
    }
}
