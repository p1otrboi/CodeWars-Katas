//Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

//Example(Input => Output):
//35231 => [1,3,2,5,3]
//0 => [0]

namespace CodeWars_Katas._8kyu
{
    internal class Convert_number_to_reversed_array_of_digits
    {
        public static long[] Digitize(long n)
        {
            var list = new List<long>();
            foreach (char c in n.ToString())
            {
                list.Add(c - 48);
            }
            list.Reverse();
            return list.ToArray();
        }
    }
}
