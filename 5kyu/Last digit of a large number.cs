//Define a function that takes in two non-negative integers A and B
//and returns the last decimal digit of A^B 

//Note that A and B may be very large!

//For example, the last decimal digit of 9^7 is 9, since 9^7 = 4782969
//The last decimal digit of (2^200)^(2^300), which has over 10^92 decimal digits,
//is 6.
//
//Also, please take 0^0 to be 1 

//You may assume that the input will always be valid.

//Examples
//GetLastDigit(4, 1)            // returns 4
//GetLastDigit(4, 2)            // returns 6
//GetLastDigit(9, 7)            // returns 9    
//GetLastDigit(10, 10000000000) // returns 0

using System.Numerics;

namespace CodeWars_Katas._5kyu
{
    internal class Last_digit_of_a_large_number
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            char[] a = n1.ToString().ToCharArray();
            char[] b = n2.ToString().ToCharArray();
            return GetLastDigit(a, b);
        }

        static int Modulus(int a, char[] b)
        {
            int mod = 0;
            for (int i = 0; i < b.Length; i++)
                mod = (mod * 10 + b[i] - '0') % a;
            return mod;
        }

        static int GetLastDigit(char[] a, char[] b)
        {
            int len_a = a.Length, len_b = b.Length;
            if (len_a == 1 && len_b == 1 && a[0] == '0' && b[0] == '0')
                return 1;
            if (len_b == 1 && b[0] == '0')
                return 1;
            if (len_a == 1 && a[0] == '0')
                return 0;
            int exp = (Modulus(4, b) == 0) ? 4 : Modulus(4, b);
            int res = (int)(Math.Pow(a[len_a - 1] - '0', exp));
            return res % 10;
        }
    }
}
