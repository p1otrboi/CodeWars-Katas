//You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.

//The returned value must be a string, and have "***" between each of its letters.

//You should not remove or add elements from/to the array.


using System.Text;

namespace CodeWars_Katas._8kyu
{
    internal class Sort_and_Star
    {
        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);
            char[] first = s[0].ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < first.Length; i++)
            {
                sb.Append(first[i]);
                if (i < first.Length - 1)
                    sb.Append("***");
            }
            return sb.ToString();
        }
    }
}
