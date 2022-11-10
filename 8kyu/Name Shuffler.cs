//Write a function that returns a string in which firstname is swapped with last name.

using System.Text;

namespace CodeWars_Katas._8kyu
{
    internal class Name_Shuffler
    {
        public static string NameShuffler(string str)
        {
            string[] stringsplit = str.Split(" ");
            StringBuilder sb = new StringBuilder();
            sb.Append(stringsplit[1]);
            sb.Append(" ");
            sb.Append(stringsplit[0]);
            return sb.ToString();
        }
    }
}
