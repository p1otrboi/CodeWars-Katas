//Write a function that takes a single string (word) as argument.The function must return an ordered list containing the indexes of all capital letters in the string.

namespace CodeWars_Katas._7kyu
{
    internal class Find_the_capitals
    {
        public static int[] Capitals(string word)
        {
            string numbers = "";
            int i = 0;

            foreach (char c in word)
            {
                if (c == char.ToUpper(c))
                {
                    numbers += i;
                }
                i++;
            }
            var intArray = numbers.Select(c => c - '0').ToArray();

            return intArray;
        }
    }
}
