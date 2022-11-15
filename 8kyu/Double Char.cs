//Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

//Examples(Input->Output):
//*"String"-> "SSttrriinngg"
//* "Hello World"-> "HHeelllloo  WWoorrlldd"
//* "1234!_ "-> "11223344!!__  "

namespace CodeWars_Katas._8kyu
{
    internal class Double_Char
    {
        public static string DoubleChar(string s)
        {
            string res = "";
            foreach (char c in s)
            {
                res += c;
                res += c;
            }
            return res;
        }
    }
}
