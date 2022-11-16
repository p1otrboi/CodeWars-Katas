//In this kata you are required to, given a string, replace every letter with its position in the alphabet.

//If anything in the text isn't a letter, ignore it and don't return it.

//"a" = 1, "b" = 2, etc.

//Example
//Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
//Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" ( as a string )

using System.Text.RegularExpressions;

namespace CodeWars_Katas._6kyu
{
    internal class Replace_With_Alphabet_Position
    {
        public static string AlphabetPosition(string text)
        {
            var rg = new Regex(@"[a-zA-Z]");
            var indexList = new List<string>();
            foreach (char c in text)
            {
                if (rg.IsMatch(c.ToString()))
                    indexList.Add(((int)c % 32).ToString());
            }
            return String.Join(' ', indexList);
        }
    }
}
