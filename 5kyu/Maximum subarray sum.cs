//The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or
//list of integers:

//maxSequence[-2, 1, -3, 4, -1, 2, 1, -5, 4]
//-- should be 6: [4, -1, 2, 1]
//Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array.
//If the list is made up of only negative numbers, return 0 instead.

//Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.

namespace CodeWars_Katas._5kyu
{
    internal class Maximum_subarray_sum
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length < 1 || arr.Max() < 0)
                return 0;
            var dict = new Dictionary<int, int>();
            var list = new List<int>();
            int keyCount = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                list.Add(arr[i]);
                dict[keyCount] = list.Sum();
                keyCount++;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    list.Add(arr[k]);
                    dict[keyCount] = list.Sum();
                    keyCount++;
                }
                list.Clear();
            }
            return dict.Values.Max();
        }
    }
}
