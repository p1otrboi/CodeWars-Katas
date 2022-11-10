// Complete the solution so that it reverses the string passed into it.

namespace CodeWars_Katas._8kyu
{
    internal class Reversed_Strings
    {
        public static string Solution(string str)
        {
            string res = "";
            char[] a = str.Reverse().ToArray();
            foreach (char c in a)
            {
                res += c.ToString();
            }
            return res;
        }
    }
}
