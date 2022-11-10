//Simple, given a string of words, return the length of the shortest word(s).

//String will never be empty and you do not need to account for different data types.

namespace CodeWars_Katas._7kyu
{
    internal class Shortest_Word
    {
        public static int FindShort(string s)
        {
            string[] words = s.Split(" ");
            int shortest = 100;
            foreach (string word in words)
            {
                int length = word.Length;
                if (length < shortest)
                    shortest = length;
            }
            return shortest;
        }
    }
}
