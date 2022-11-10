//Return the number (count) of vowels in the given string.

//We will consider a, e, i, o, u as vowels for this Kata (but not y).

//The input string will only consist of lower case letters and/or spaces.

namespace CodeWars_Katas._7kyu
{
    internal class Vowel_Count
    {
        public static int GetVowelCount(string str)
        {

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            int vowelCount = str.Count(c => vowels.Contains(c));
            return vowelCount;
        }
    }
}
