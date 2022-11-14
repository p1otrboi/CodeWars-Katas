//Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

//Examples
//"This is an example!" ==> "sihT si na !elpmaxe"
//"double  spaces"      ==> "elbuod  secaps"


using System.Text;

namespace CodeWars_Katas._7kyu
{
    internal class Reverse_Words
    {
        public static string ReverseWords(string str)
        {
            var sb = new StringBuilder();
            foreach (var word in str.Split())
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }
                sb.Append(' ');
            }
            return sb.ToString().Trim();
        }
    }
}
