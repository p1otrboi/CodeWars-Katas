//Write a function that will return the count of distinct case-insensitive alphabetic characters and
//numeric digits that occur more than once in the input string. The input string can be assumed to
//contain only alphabets (both uppercase and lowercase) and numeric digits.

//Example
//"abcde" -> 0 # no characters repeats more than once
//"aabbcde" -> 2 # 'a' and 'b'
//"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
//"indivisibility" -> 1 # 'i' occurs six times
//"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
//"aA11" -> 2 # 'a' and '1'
//"ABBA" -> 2 # 'A' and 'B' each occur twice

namespace CodeWars_Katas._6kyu
{
    internal class Counting_Duplicates
    {
        public static int DuplicateCount(string str)
        {
            int i = 0;
            var dict = new Dictionary<char, int>();
            var chars = str.ToUpper().ToCharArray();
            foreach (var c in chars)
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 0);
                else if (dict.ContainsKey(c))
                    dict[c]++;
            }
            foreach (var item in dict)
                if (item.Value > 0) { i++; }
            return i;
        }
    }
}
