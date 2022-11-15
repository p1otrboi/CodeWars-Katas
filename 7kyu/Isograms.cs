//An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string
//that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

//Example: (Input-- > Output)

//"Dermatoglyphics"-- > true "aba"-- > false "moOse"-- > false(ignore letter case)

namespace CodeWars_Katas._7kyu
{
    internal class Isograms
    {
        public static bool IsIsogram(string str)
        {
            var dict = new Dictionary<char, int>();
            foreach (char c in str.ToUpper())
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);
                else if (dict.ContainsKey(c))
                    dict[c]++;
            }
            foreach (var item in dict.Values)
                if (item > 1)
                    return false;
            return true;
        }
    }
}
