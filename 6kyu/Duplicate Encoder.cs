//The goal of this exercise is to convert a string to a new string where each character in the new string
//is "(" if that character appears only once in the original string, or ")" if that character appears more
//than once in the original string. Ignore capitalization when determining if a character is a duplicate.

//Examples
//"din"      =>  "((("
//"recede"   =>  "()()()"
//"Success"  =>  ")())())"
//"(( @"     =>  "))((" 

//Notes
//Assertion messages may be unclear about what they display in some languages.
//If you read "...It Should encode XXX", the "XXX" is the expected result, not the input!


using System.Text;

namespace CodeWars_Katas._6kyu
{
    internal class Duplicate_Encoder
    {
        public static string DuplicateEncode(string word)
        {
            var chars = word.ToLower().ToCharArray();
            var map = new Dictionary<char, int>();
            var sb = new StringBuilder();
            foreach (char c in chars)
            {
                if (!map.ContainsKey(c))
                    map[c] = 0;
                map[c]++;
            }
            foreach (char c in chars)
            {
                if (map[c] > 1)
                    sb.Append(")");
                else
                    sb.Append("(");
            }
            return sb.ToString();
        }
    }
}
