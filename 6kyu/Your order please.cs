//Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

//Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

//If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

//Examples
//"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
//"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
//""  -->  ""

using System.Text.RegularExpressions;

namespace CodeWars_Katas._6kyu
{
    internal class Your_order_please
    {
        public static string Order(string words)
        {
            Regex rg = new Regex(@"[1-9]");
            MatchCollection matches = rg.Matches(words);
            var wordsarr = words.Split();
            string[] result = new string[matches.Count];
            int index = 0;
            foreach (Match match in matches)
            {
                result[int.Parse(match.Value) - 1] = wordsarr[index++];
            }
            return String.Join(' ', result);
        }
    }
}
