//Move the first letter of each word to the end of it, then add "ay" to the end of the word.
//Leave punctuation marks untouched.

//Examples
//Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
//Kata.PigIt("Hello world !");     // elloHay orldway !


using System.Text;

namespace CodeWars_Katas._5kyu
{
    internal class Simple_Pig_Latin
    {
        public static string PigIt(string str)
        {
            var sb = new StringBuilder();
            foreach (var word in str.Split())
            {
                sb.Append(word.Remove(0, 1));
                sb.Append(word[0]);
                if (word.Length > 1)
                    sb.Append("ay");
                sb.Append(' ');
            }
            return sb.ToString().Trim();
        }
    }
}
