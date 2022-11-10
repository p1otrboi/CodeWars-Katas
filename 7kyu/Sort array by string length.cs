//Write a function that takes an array of strings as an argument and returns a sorted array containing the same strings, ordered from shortest to longest.

//For example, if this array were passed as an argument:

//["Telescopes", "Glasses", "Eyes", "Monocles"]

//Your function would return the following array:

//["Eyes", "Glasses", "Monocles", "Telescopes"]

//All of the strings in the array passed to your function will be different lengths, so you will not have to decide how to order multiple strings of the same length.

namespace CodeWars_Katas._7kyu
{
    internal class Sort_array_by_string_length
    {
        public static string[] SortByLength(string[] array)
        {
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            string[] result = new string[array.Length];
            int i = 0;
            foreach (string s in array)
                result[i++] = s;
            return result;
        }
    }
}
