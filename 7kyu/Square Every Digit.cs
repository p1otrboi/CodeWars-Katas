//Welcome.In this kata, you are asked to square every digit of a number and concatenate them.

//For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

//Note: The function accepts an integer and returns an integer

namespace CodeWars_Katas._7kyu
{
    internal class Square_Every_Digit
    {
        public static int SquareDigits(int n)
        {
            char[] input = n.ToString().ToCharArray();
            string output = string.Empty;
            foreach (char c in input)
            {
                int a = Convert.ToInt32(c.ToString());
                output += (a * a).ToString();
            }
            return Convert.ToInt32(output);
        }
    }
}
