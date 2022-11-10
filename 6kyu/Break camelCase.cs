//Complete the solution so that the function will break up camel casing, using a space between words.

namespace CodeWars_Katas._6kyu
{
    internal class Break_camelCase
    {
        public static string BreakCamelCase(string str)
        {
            // complete the function
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    result += ' ';
                }

                result += str[i];
            }

            return result.Trim();
        }
    }
}
