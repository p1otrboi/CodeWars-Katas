//Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

namespace CodeWars_Katas._7kyu
{
    internal class String_ends_with
    {
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending) ? true : false;
        }
    }
}
