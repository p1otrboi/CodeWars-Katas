//Given an array of integers, find the one that appears an odd number of times.

//There will always be only one integer that appears an odd number of times.

//Examples
//[7] should return 7, because it occurs 1 time (which is odd).
//[0] should return 0, because it occurs 1 time (which is odd).
//[1,1,2] should return 2, because it occurs 1 time (which is odd).
//[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
//[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).

namespace CodeWars_Katas._6kyu
{
    internal class Find_the_odd_int
    {
        public static int find_it(int[] seq)
        {
            var dict = new Dictionary<int, int>();
            foreach (int i in seq)
            {
                if (!dict.ContainsKey(i))
                    dict[i] = 0;
                dict[i]++;
            }
            foreach (var value in dict)
            {
                if (value.Value % 2 == 1)
                    return value.Key;
            }
            throw new Exception("No int occurs odd times");
        }
    }
}
